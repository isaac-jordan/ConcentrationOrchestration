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

        public void ApplyNewScaledValue(double value)
        {
            int trackTopYLocation = gameWindow.BallTrackImage.Location.Y;
            int trackBottomYLocation = trackTopYLocation + gameWindow.BallTrackImage.Size.Height;

            double uiValue = ScaleValueForUI(value, trackTopYLocation, trackBottomYLocation);
            Console.WriteLine("UI Value: " + uiValue);
            gameWindow.setBallYValue(Convert.ToInt32(uiValue));
        }

        public double ScaleValueForUI(double value, double min, double max)
        {
            Console.WriteLine("Min: " + min + " value: " + value + " max: " + max);
            return min + value * (max - min);
        }
    }
}
