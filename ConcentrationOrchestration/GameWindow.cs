using Emotiv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcentrationOrchestration
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();

            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public void setBallYValue(int newYValue)
        {
            //Console.WriteLine("New Y Coord: " + newYValue);
            BallImage.Location = new Point(BallImage.Location.X, newYValue);
        }

        public void setPerformanceYValue(int newYValue)
        {
            PerformanceMeasure.Location = new Point(PerformanceMeasure.Location.X, newYValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmoEngine.Instance.MentalCommandSetActiveActions(0, (uint)EdkDll.IEE_MentalCommandAction_t.MC_LEFT);
            EmoEngine.Instance.MentalCommandSetActiveActions(0, (uint)EdkDll.IEE_MentalCommandAction_t.MC_RIGHT);
            Console.WriteLine("Setting MentalCommand active actions for user");
        }

        private void StartTrainFrownButton_Click(object sender, EventArgs e)
        {
            UserInputHandler.StartTraining(EdkDll.IEE_MentalCommandAction_t.MC_LIFT);
            EmoEngine.Instance.FacialExpressionSetTrainingControl(0, EdkDll.IEE_FacialExpressionTrainingControl_t.FE_ACCEPT);
        }
    }
}
