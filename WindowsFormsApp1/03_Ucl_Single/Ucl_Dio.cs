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
    public partial class Ucl_Dio : UserControl
    {
        public Trd_Dio Trd_DioObj { get; set; } = null;

        private bool[] InStates => Trd_DioObj?.InStates;
        private bool[] OutStates => Trd_DioObj?.OutStates;

        public string[] InNames;
        public string[] OutNames;

        public Ucl_Dio()
        {
            InitializeComponent();
        }

        private void Chl_DioOutState_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            OutStates[e.Index] = e.NewValue == CheckState.Checked;
        }

        private void Tmr_Polling_Tick(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void UpdateState()
        {
            UpdateState(Chl_DioInState, InStates, InNames);
            UpdateState(Chl_DioOutState, OutStates, OutNames);
        }

        private static void UpdateState(CheckedListBox checkedListBox, bool[] state, string[] names)
        {
            if (state == null)
            {
                return;
            }

            if (checkedListBox.Items.Count != state.Length)
            {
                checkedListBox.Items.Clear();
                foreach (var i in Enumerable.Range(0, state.Length))
                {
                    checkedListBox.Items
                        .Add(i < names.Length ? names[i] : "", state[i]);
                }
            }
            else
            {
                foreach (var i in Enumerable
                    .Range(0, checkedListBox.Items.Count))
                {
                    checkedListBox.SetItemChecked(i, state[i]);
                }
            }
        }
    }
}
