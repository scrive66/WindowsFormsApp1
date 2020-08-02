using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1._13_Trd_Single;

namespace WindowsFormsApp1._12_Trd_Multi
{
    class Trd_Multi
    {
        const int IN_NUM = 8;
        const int OUT_NUM = 8;

        private enum IN_NAME
        {
            Start,
            Reset,
            Emg,
        }

        private readonly Trd_Dio _Trd_DioObj;

        public bool IsStartPbOn => _Trd_DioObj.InStates[(int)IN_NAME.Start];
        public bool IsResetPbOn => _Trd_DioObj.InStates[(int)IN_NAME.Reset];
        public bool IsEmgergency => _Trd_DioObj.InStates[(int)IN_NAME.Emg];

        public Trd_Multi(Trd_Dio trd_DioObj)
        {
            _Trd_DioObj = trd_DioObj;
        }

        public void Init()
        {
            _Trd_DioObj.Init(IN_NUM, OUT_NUM);
        }
    }
}
