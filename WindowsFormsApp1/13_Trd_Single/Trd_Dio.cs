using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1._13_Trd_Single
{
    public class Trd_Dio
    {
        public bool[] InStates { get; private set; }
        public bool[] OutStates { get; set; }

        private Timer _PollingTimer;
        private const int TIMER_DUE_TIME = 50;
        private const int TIMER_PERIOD = 50;


        public Trd_Dio()
        {
        }

        public void Init(int inNum, int outNum)
        {
            InStates = new bool[inNum];
            OutStates = new bool[outNum];

            _PollingTimer
                = new Timer(Polling, null, TIMER_DUE_TIME, TIMER_PERIOD);
        }
        private void Polling(object state)
        {
            for (int i = 0; i < InStates.Length; i++)
            {
                InStates[i] = OutStates[i];
            }
        }
    }

}
