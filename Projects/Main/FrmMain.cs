using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent(); ;
        }

        private readonly string _solution = ConfigurationManager.AppSettings["Solution"];

        private void BtnNotice_Click(object sender, EventArgs e)
        {
            Process.Start(_solution + ConfigurationManager.AppSettings["Notice"]);
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(@"Do you want to save changes to your text?", "My Application",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}