using Emotiv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcentrationOrchestration
{
    static class Program
    {
        private static readonly int fps = 60;
        private static readonly int sleepMilliSeconds = (int)Math.Round(1.0 / fps * 1000);
        private static EmoEngine engine = null;
        public static DisplayInputHandler displayInputHandler;
        private static int userID = -1;

        static void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {
            Console.WriteLine("User Added Event has occured");
            userID = (int)e.userId;

            EmoEngine.Instance.IEE_FFTSetWindowingType((uint)userID, EdkDll.IEE_WindowingTypes.IEE_HAMMING);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            engine = EmoEngine.Instance;
            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);
            engine.Connect();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GameWindow window = new GameWindow();
            displayInputHandler = new DisplayInputHandler(window);

            Application.Idle += new EventHandler(Application_Idle);

            Application.Run(window);
        }

        static void Application_Idle(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            double currentAcceleration = 0;
            double currentPosition = 0;

            double maxAcceleration = 1;

            while (true)
            {
                if (engine.EngineGetNumUser() > 0)
                {
                    engine.IEE_FFTSetWindowingType(0, EdkDll.IEE_WindowingTypes.IEE_HAMMING);
                }

                engine.ProcessEvents(100);

                WaveData alphaWD = new WaveData("alpha");
                WaveData low_betaWD = new WaveData("low_beta");
                WaveData high_betaWD = new WaveData("high_beta");
                WaveData gammaWD = new WaveData("gamma");
                WaveData thetaWD = new WaveData("theta");

                double[] alpha = new double[1];
                double[] low_beta = new double[1];
                double[] high_beta = new double[1];
                double[] gamma = new double[1];
                double[] theta = new double[1];

                EdkDll.IEE_DataChannel_t[] channelList = new EdkDll.IEE_DataChannel_t[5] { EdkDll.IEE_DataChannel_t.IED_AF3, EdkDll.IEE_DataChannel_t.IED_AF4, EdkDll.IEE_DataChannel_t.IED_T7,
                                                                                       EdkDll.IEE_DataChannel_t.IED_T8, EdkDll.IEE_DataChannel_t.IED_O1 };

                for (int i = 0; i < 5; i++)
                {
                    engine.IEE_GetAverageBandPowers(0, channelList[i], theta, alpha, low_beta, high_beta, gamma);
                    //Console.Write(theta[0] + ",");
                    //Console.Write(alpha[0] + ",");
                    //Console.Write(low_beta[0] + ",");
                    //Console.Write(high_beta[0] + ",");
                    //Console.WriteLine(gamma[0] + ",");

                    //Console.WriteLine("");

                    alphaWD.AddVal(alpha[0]);
                    low_betaWD.AddVal(low_beta[0]);
                    high_betaWD.AddVal(high_beta[0]);
                    gammaWD.AddVal(gamma[0]);
                    thetaWD.AddVal(theta[0]);

                }
                if (!stopWatch.IsRunning)
                {
                    stopWatch.Start();
                    Console.WriteLine("Starting stopwatch.");
                } else
                {
                    stopWatch.Stop();
                    long timeDeltaTicks = stopWatch.ElapsedTicks;


                    double accChange = AccelerationChange(alphaWD, low_betaWD, high_betaWD, thetaWD, gammaWD);
                    Console.WriteLine("Acceleration change: " + accChange);

                    currentAcceleration = BindToMaxValue(currentAcceleration + accChange, maxAcceleration);
                    //double newPosition = currentPosition + 0.5 * currentAcceleration * timeDeltaTicks * timeDeltaTicks;
                    double newPosition = currentPosition + 0.5 * currentAcceleration; // Time is unitary

                    Console.WriteLine("CurrAcc: {0}, TimeDelta: {1}, NewPos: {2}",
                        currentAcceleration, timeDeltaTicks, newPosition);
                    if (newPosition > 1)
                    {
                        try
                        {
                            ThreadPool.QueueUserWorkItem(
                                     delegate (object param)
                                     {
                                         WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                                         player.URL = "resources\\bell.mp3";
                                         player.controls.play();
                                     });
                        } catch (Exception)
                        {
                            // Nada
                        }
                        
                        Console.WriteLine("VICTORY!");
                        // END PROGRAM
                    } else if (newPosition < 0)
                    {
                        currentPosition = 0;
                        currentAcceleration = 0;
                    } else
                    {
                        currentPosition = newPosition;
                    }

                    //double currentPosition = SimpleLinearVal(low_betaWD, high_betaWD);
                    Console.WriteLine(currentPosition);

                    if (!Double.IsNaN(currentPosition))
                    {
                        Console.WriteLine("New position (formerly Awesome value):" + currentPosition);
                        displayInputHandler.ApplyNewScaledValue(currentPosition);
                    }
                    stopWatch.Reset();
                    stopWatch.Start();
                }

                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                
            }
        }

        // Assumption: brain waves are equally likely to be of any power. Goal: keep return value of this function statistically between -1 and 1.
        // Method: tinker with
        public static double AccelerationChange(WaveData alphaWD, WaveData low_betaWD, WaveData high_betaWD, WaveData thetaWD, WaveData gammaWD)
        {
            Console.WriteLine("Waves: A: {0}, LB: {1}, HB: {2}, T: {3}, G: {4}", alphaWD.DecibelValue(), low_betaWD.DecibelValue(), high_betaWD.DecibelValue(), thetaWD.DecibelValue(), gammaWD.DecibelValue());
            double sum = 0;
            double scalingFactor = 1;
            double gravity = 0;

            double[] waveValues = new double[] { low_betaWD.DecibelValue(), high_betaWD.DecibelValue(), alphaWD.DecibelValue(), thetaWD.DecibelValue(), gammaWD.DecibelValue() };

            //// SUMS

            //double weightedSum = 1.0 * low_betaWD.NormalizedValue() + 1.0 * high_betaWD.NormalizedValue() + 0.5 * alphaWD.NormalizedValue() - 1.5 * thetaWD.NormalizedValue() - 0.5 * gammaWD.NormalizedValue();
            double mixedWeightedSum = 1.0 * low_betaWD.DecibelValue() + 1.0 * high_betaWD.DecibelValue() + 0.5 * alphaWD.DecibelValue() - 1.5 * thetaWD.DecibelValue() - 0.5 * gammaWD.DecibelValue();
            double positiveWeightedSum = 1.0 * low_betaWD.DecibelValue() + 1.0 * high_betaWD.DecibelValue() + 0.5 * alphaWD.DecibelValue() + 0.5 * thetaWD.DecibelValue() + 0.5 * gammaWD.DecibelValue();
            double simpleSum = waveValues.Sum();
            
            
            //// Scaling-used values

            double span = waveValues.Max() - waveValues.Min();
            double average = waveValues.Average();


            //// Different scaling showcases, intended to be more consistent across the magnitude space

            // Span-inversely-proportional scaling
            //scalingFactor = 1 / span;

            // Magnitude-inversely-proportional scaling
            //scalingFactor = 1 / average;

            // Magnitude-complement-proportional scaling
            //scalingFactor = 1 - average;

            //// Packaged scalings

            // Best Relaxation Tailoring
            sum = simpleSum;
            scalingFactor = 1 - average;
            gravity = -0.1;
            



            return sum * scalingFactor - gravity; // Alternatively, gravity could be subtracted from sum directly
        }

        public static double SimpleLinearVal(WaveData low_betaWD, WaveData high_betaWD)
        {
            return (low_betaWD.NormalizedValue() + high_betaWD.NormalizedValue()) / 2.0;
        }
    
        public static double BindToMaxValue(double newValue, double maxValue)
        {
            if (newValue > maxValue)
            {
                return maxValue;
            } else
            {
                return newValue;
            }
        }
    }

        
    
    public class WaveData
    {
        // Fields
        public string name { get; }

        public List<double> values;

        public double curVal { get; set; }
        public double minVal { get; set; }
        public double maxVal { get; set; }

        // Constructor
        public WaveData(string name)
        {
            this.name = name;
            this.values = new List<double>();
            this.curVal = 0;
            this.minVal = 0;
            this.maxVal = 0;
        }
       
        // Other Methods
        public double NormalizedValue()
        {
            double denom = (this.maxVal - this.minVal);
            if (denom == 0) return 0;
            return (this.curVal - this.minVal) / denom;
        }

        // Expected values are between -10dB and 20dB
        public double DecibelValue()
        {
            double referencePower = 1;
            if (curVal == 0)
            {
                return -20;
            }
            if (curVal < 0)
            {
                throw new Exception("EEG value less than zero");
            }
            return 10 * Math.Log10( this.curVal / referencePower);
        }

        public void AddVal(double val)
        {
            this.values.Add(val);
            this.curVal = val;
            if (val > this.maxVal)
            {
                this.maxVal = val;
            }
            if (val < this.minVal)
            {
                this.minVal = val;
            }
        }
    }

}
