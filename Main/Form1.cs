using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string _solution = ConfigurationManager.AppSettings["Solution"];

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            //MessageBox.Show(_solution + ConfigurationManager.AppSettings["Inventory"]);
            Process.Start(_solution + ConfigurationManager.AppSettings["Notice"]);
            this.Close();
        }
    }
}