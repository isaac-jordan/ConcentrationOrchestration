using Emotiv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcentrationOrchestration
{
    class UserInputHandler
    {
        private static uint userID = 0;

        public static void StartTraining(EdkDll.IEE_MentalCommandAction_t command)
        {
            EmoEngine.Instance.MentalCommandSetTrainingAction(userID, command);
            EmoEngine.Instance.MentalCommandSetTrainingControl(userID, EdkDll.IEE_MentalCommandTrainingControl_t.MC_START);
        }
    }
}
