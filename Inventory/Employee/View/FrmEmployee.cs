using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Connection;

namespace Inventory.Employee.View
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            ConnectionDb.Connect.Close();
        }
    }
}