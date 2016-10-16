using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcentrationOrchestration
{
    class DisplayInputHandler
    {
        private GameWindow gameWindow;

        public DisplayInputHandler(GameWindow window)
        {
            gameWindow = window;
        }

        public void ApplyNewScaledValueForBall(double value)
        {
            //Console.WriteLine("UI Input value: " + value);
            value = 1 - value;
            int trackTopYLocation = gameWindow.BallTrackImage.Location.Y;
            int trackBottomYLocation = trackTopYLocation + gameWindow.BallTrackImage.Size.Height;

            double uiValue = ScaleValueForUI(value, trackTopYLocation, trackBottomYLocation);
            //Console.WriteLine("UI Value: " + uiValue);
            gameWindow.setBallYValue(Convert.ToInt32(uiValue));
        }

        public void ApplyNewScaledValueForMeasure(double value)
        {
            Console.WriteLine("UI Input value: " + value);
            if (value < 0)
            {
                value = 0;
            }

            if (value > 1)
            {
                value = 1;
            }

            //value = 1 - value;

            int trackTopYLocation = gameWindow.PerformanceIndicatorTrack.Location.Y;
            int trackBottomYLocation = trackTopYLocation + gameWindow.PerformanceIndicatorTrack.Size.Height;

            double uiValue = ScaleValueForUI(value, trackTopYLocation, trackBottomYLocation);
            Console.WriteLine("UI Value: " + uiValue);
            gameWindow.setPerformanceYValue(Convert.ToInt32(uiValue));
        }

        public double ScaleValueForUI(double value, double min, double max)
        {
            //Console.WriteLine("Min: " + min + " value: " + value + " max: " + max);
            return min + value * (max - min);
        }
    }
}
