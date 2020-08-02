using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1._01_Form
{
    public partial class Frm_Password : Form
    {
        public bool Unlocked { get; private set; } = false;

        private const string PASSWORD = "password";

        public Frm_Password()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Unlocked = Txt_Password.Text == PASSWORD;
            Close();
        }
    }
}
