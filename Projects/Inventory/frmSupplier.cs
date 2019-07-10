using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class frmSupplier : Form
    {
        private Boolean b;

        private SqlCommand com;

        private SqlDataAdapter da;

        private DataTable dt;
        private DialogResult re1;

        public frmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            Myoperation.myConnection();
            Myoperation.Onoff(this, false);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search ID or Name here...";
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "NEW")
            {
                b = true;
                Myoperation.Onoff(this, true);
                btnNew.Text = "Cancel";
                btnNew.Image = Inventory.Properties.Resources.cancel_2_25px;
                btnEdit.Enabled = false;
                txtSub.Focus();
            }
            else
            {
                DialogResult re = DialogResult.Yes;
                re = MessageBox.Show("Do you want to cancel", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    Myoperation.ClearData(this);
                    Myoperation.Onoff(this, false);
                    btnNew.Text = "NEW";
                    btnNew.Image = Inventory.Properties.Resources.add1;
                }
            }
        }

        private void LoadData()
        {
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}