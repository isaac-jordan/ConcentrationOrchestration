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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            engine = EmoStateHandler.InitialiseEngine();

            if (engine.EngineGetNumUser() <= 0)
            {
                Console.WriteLine("No headset detected!");
                //return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            window = new Form1();

            Application.Idle += new EventHandler(Application_Idle);
        
            Application.Run(window);
        }

        static void Application_Idle(object sender, EventArgs e)
        {
            window.CurrentMentalState.Text = "BLAH";
            engine.ProcessEvents(200);

            double[] theta = new double[1];
            double[] alpha = new double[1];
            double[] low_beta = new double[1];
            double[] high_beta = new double[1];
            double[] gamma = new double[1];

            int result = engine.IEE_GetAverageBandPowers(0, EdkDll.IEE_DataChannel_t.IED_SYNC_SIGNAL,
                theta,
                alpha,
                low_beta,
                high_beta,
                gamma);

            if (result == EdkDll.EDK_OK || true)
            {
                Console.Write("Theta:");
                foreach (var item in theta)
                    Console.Write("{0}", item);
                Console.WriteLine("");

                Console.Write("alpha:");
                foreach (var item in alpha)
                    Console.Write("{0}", item);
                Console.WriteLine("");

                Console.Write("low_beta:");
                foreach (var item in low_beta)
                    Console.Write("{0}", item);
                Console.WriteLine("");

                Console.Write("high_beta:");
                foreach (var item in high_beta)
                    Console.Write("{0}", item);
                Console.WriteLine("");

                Console.Write("gamma:");
                foreach (var item in gamma)
                    Console.Write("{0}", item);
                Console.WriteLine("");

                Console.WriteLine("");
            }
        }
}
}
