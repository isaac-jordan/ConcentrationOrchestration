using Emotiv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcentrationOrchestration
{
    static class Program
    {
        private static readonly int fps = 60;
        private static readonly int sleepMilliSeconds = (int)Math.Round(1.0 / fps * 1000);
        private static EmoEngine engine = null;
        public static Form1 window;
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

            window = new Form1();

            Application.Idle += new EventHandler(Application_Idle);

            Application.Run(window);
        }

        static void Application_Idle(object sender, EventArgs e)
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

            double avgGamma = 0;
            for (int i = 0; i < 5; i++)
            {
                engine.IEE_GetAverageBandPowers(0, channelList[i], theta, alpha, low_beta, high_beta, gamma);
                Console.Write(theta[0] + ",");
                Console.Write(alpha[0] + ",");
                Console.Write(low_beta[0] + ",");
                Console.Write(high_beta[0] + ",");
                Console.WriteLine(gamma[0] + ",");

                Console.WriteLine("");

                alphaWD.addVal(alpha[0]);
                low_betaWD.addVal(low_beta[0]);
                high_betaWD.addVal(high_beta[0]);
                gammaWD.addVal(gamma[0]);
                thetaWD.addVal(theta[0]);

            }

            avgGamma = avgGamma / 5;
            window.CurrentMentalState.Text = "Gamma: " + avgGamma;
        }



        public static double BallAcceleration(WaveData low_betaWD, WaveData high_betaWD, WaveData alphaWD, WaveData thetaWD, WaveData gammaWD)
        {
            double sum = 1.0 * low_betaWD.curVal + 1.0 * high_betaWD.curVal + 0.5 * alphaWD.curVal - 1.5 * thetaWD.curVal - 1.0 * gammaWD.curVal;
            return sum / 5.0;
        }
    
        public static double checkVelocity(double newVelocity, double maxVelocity)
        {
            if (newVelocity > maxVelocity)
            {
                return maxVelocity;
            } else
            {
                return newVelocity;
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
            return (this.curVal - this.minVal) / (this.maxVal - this.minVal);
        }

        public void addVal(double val)
        {
            this.values.Add(val);
            this.curVal = val;
        }
    }

    }
