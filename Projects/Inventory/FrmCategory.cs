using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class FrmCategory : Form

    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private Boolean b;
        private SqlCommand com;
        private SqlDataAdapter da;
        private DataTable dt;
        private string catID = "0";

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "NEW")
            {
                b = true;
                Myoperation.Onoff(this, true);
                btnNew.Text = "Cancel";
                btnNew.Image = Inventory.Properties.Resources.jellyfish;
                btnEdit.Enabled = false;

                txtCate.Focus();
            }
            else
            {
                DialogResult re = DialogResult.Yes;
                re = MessageBox.Show("Do you want to Cancel", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    Myoperation.ClearData(this);
                    Myoperation.Onoff(this, false);

                    btnNew.Text = "NEW";
                    btnNew.Image = Inventory.Properties.Resources.pet1;
                }
            }
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            Myoperation.Onoff(this, false);
            Myoperation.myConnection();
            txtID.Text = "Auto NUmber";
            txtSearch.Text = "Search ID or Name here....";

            LoadData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCate.Text.Trim()))
            {
                MessageBox.Show("Please input Category", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (b == true)
            {
                Modify("InsertCategory");
                MessageBox.Show("Your record was saved...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Modify("UpdateCategory");
                MessageBox.Show("Your record was updated...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
            Myoperation.ClearData(this);
            Myoperation.Onoff(this, false);
        }

        private void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM dbo.GetCategory()", Myoperation.con);
            dt = new DataTable();
            da.Fill(dt);
            lsvCategory.Clear();
            lsvCategory.View = View.Details;
            //Add Column Header
            lsvCategory.Columns.Add("ID", 54);
            lsvCategory.Columns.Add("Category", 420);
            //Load data from table into listview
            string[] arr = new string[2];
            ListViewItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                arr[0] = dr[0].ToString();
                arr[1] = dr[1].ToString();
                item = new ListViewItem(arr);
                lsvCategory.Items.Add(item);
            }
            // Alternative color
            foreach (ListViewItem list in lsvCategory.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }
            dt.Dispose();
            da.Dispose();
        }

        private void Modify(string X)
        {
            com = new SqlCommand(X, Myoperation.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", int.Parse(catID.ToString()));
            com.Parameters.AddWithValue("@c", txtCate.Text);
            com.ExecuteNonQuery();
            com.Dispose();
        }

        private void LsvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCategory.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvCategory.SelectedItems[0]; // row
                catID = item.SubItems[0].Text; // colum id
                txtCate.Text = item.SubItems[1].Text;
                btnEdit.Enabled = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            btnNew.Text = "Cancel";
            btnNew.Image = Inventory.Properties.Resources.do_not_disturb_25px;
            Myoperation.Onoff(this, true);
            txtCate.Focus();
            btnEdit.Enabled = false;
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("SearchCat", Myoperation.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@c", txtSearch.Text);

            da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);
            lsvCategory.Clear();
            string[] arr = new string[2];
            lsvCategory.Columns.Add("ID", 54);
            lsvCategory.Columns.Add("Category", 420);
            lsvCategory.View = View.Details;
            ListViewItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                arr[0] = row[0].ToString();
                arr[1] = row[1].ToString();

                item = new ListViewItem(arr);
                lsvCategory.Items.Add(item);
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.Text = "Search ID or Name here...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search ID or Name here....")
            {
                txtSearch.Text = null;
                txtSearch.ForeColor = Color.Black;
            }
        }
    }
}