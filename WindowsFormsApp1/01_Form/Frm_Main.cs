using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1._12_Trd_Multi;
using WindowsFormsApp1._13_Trd_Single;
using static WindowsFormsApp1._12_Trd_Multi.Trd_Main;

namespace WindowsFormsApp1._01_Form
{
    public partial class Frm_Main : Form
    {
        #region 表示テキスト
        private const string MACHINE_NAME = "サンプル設備";

        private static readonly Dictionary<STATE_MAIN, string> STATE_NAME
            = new Dictionary<STATE_MAIN, string>
            {
                { STATE_MAIN.Initializing, "初期化中" },
                { STATE_MAIN.WaitingForReturningOrigin, "原点復帰待ち" },
                { STATE_MAIN.ReturningOrigin, "原点復帰中" },
                { STATE_MAIN.WaitingForMovingHomePosition, "原位置移動待ち" },
                { STATE_MAIN.MovingHomePosition, "原位置移動中" },
                { STATE_MAIN.WaitingForProducing, "自動開始待ち" },
                { STATE_MAIN.Producing, "自動中" },
                { STATE_MAIN.OperatingManually, "手動中" },
                { STATE_MAIN.WaitingForErrorRelease, "エラー解除待ち" },
                { STATE_MAIN.Ending, "終了中" },
            };
        #endregion

        private Trd_Main _StateManagementObj;

        private Trd_Multi _Trd_MultiObj;
        private Trd_Dio _Trd_DioObj;

        public Frm_Main()
        {
            InitializeComponent();

            Lbl_MachineName.Text = MACHINE_NAME;
        }

        private void Frm_Main_Load(object sender, System.EventArgs e)
        {
            _Trd_DioObj = new Trd_Dio();
            _Trd_MultiObj = new Trd_Multi(_Trd_DioObj);
            Ucl_SingleObj.Trd_DioObj = _Trd_DioObj;

            ChangeUcl(Ucl_ProcessObj);

            _StateManagementObj = new Trd_Main(_Trd_MultiObj);
            _StateManagementObj.Messenger += new Action<string>(x =>
            {
                Invoke(new Action(() =>
                {
                    Rtb_Log?.Focus();
                    Rtb_Log?.AppendText(x + Environment.NewLine);
                }));
            });
            _StateManagementObj.Start();
        }


        private void Tmr_Update_Tick(object sender, EventArgs e)
        {
            Lbl_State.Text = STATE_NAME[_StateManagementObj.CurrentState];

            Lbl_DateTime.Text
                = DateTime.Now.ToString("yyyy/MM/dd"
                + Environment.NewLine + "HH:mm:ss");
        }

        private void Tsm_Process_Click(object sender, EventArgs e)
        {
            ChangeUcl(Ucl_ProcessObj);
        }
        private void Tsm_Password_Click(object sender, EventArgs e)
        {
            var frm = new Frm_Password();
            frm.ShowDialog();

            var visible = frm.Unlocked;
            Tsm_Single.Visible = visible;
            Tsm_Setting.Visible = visible;
        }

        private void Tsm_Single_Click(object sender, EventArgs e)
        {
            ChangeUcl(Ucl_SingleObj);
        }

        private void Tsm_Setting_Click(object sender, EventArgs e)
        {
            ChangeUcl(Ucl_SettingObj);
        }

        private void Tsm_EndSoftware_Click(object sender, EventArgs e)
        {
            _StateManagementObj.ShouldEndSoftware = true;
        }

        private void ChangeUcl(UserControl userControl)
        {
            foreach (var ctrl in Pnl_Ucls.Controls)
            {
                if (ctrl is UserControl ucl)
                {
                    ucl.Visible = false;
                }
            }

            userControl.Visible = true;
            userControl.Dock = DockStyle.Fill;
        }

    }
}
