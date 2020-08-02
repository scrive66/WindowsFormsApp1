using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1._13_Trd_Single;

namespace WindowsFormsApp1._03_Ucl_Single
{
    public partial class Ucl_Single : UserControl
    {
        private Trd_Dio _Trd_DioObj;

        private static readonly string[] DioInNames
            = {
                "Start",
                "Reset",
                "EMG",
            };

        private static readonly string[] DioOutNames
            = {
                "StartLP",
                "ResetLP",
                "EMGLP",
            };

        public Trd_Dio Trd_DioObj
        {
            get => _Trd_DioObj;
            set
            {
                _Trd_DioObj = value;
                Ucl_DioObj.Trd_DioObj = _Trd_DioObj;
            }
        }

        public Ucl_Single()
        {
            InitializeComponent();

            Ucl_DioObj.InNames = DioInNames;
            Ucl_DioObj.OutNames = DioOutNames;
        }
    }
}
