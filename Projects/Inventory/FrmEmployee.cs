using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Connection;

namespace Inventory.Employee.View
{
    public partial class FrmEmployee : Form
    {
        private string fp;
        private Boolean b;
        private SqlCommand com;
        private byte[] photo;
        private SqlDataAdapter da;

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            myOperation.myConnection();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Insert("InsertEmployee");
        }

        private void Insert(string store)
        {
            var salary = Decimal.Parse(txtSalary.Text, NumberStyles.Currency);
            com = new SqlCommand(store, myOperation.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", txtID.Text);
            com.Parameters.AddWithValue("@n", txtName.Text);
            if (rdoFemale.Checked == true)
                com.Parameters.AddWithValue("@g", "F");
            else
                com.Parameters.AddWithValue("@g", "M");
            com.Parameters.AddWithValue("@d", dtpDOB.Value);
            com.Parameters.AddWithValue("@po", txtPos.Text);
            com.Parameters.AddWithValue("@s", salary);
            com.Parameters.AddWithValue("@a", txtAddress.Text);
            com.Parameters.AddWithValue("@c", txtPhone.Text);
            com.Parameters.AddWithValue("@h", dtpHired.Value);
            if (fp != null)
                photo = File.ReadAllBytes(fp);
            com.Parameters.AddWithValue("@pt", photo);
            com.ExecuteNonQuery();//run stored procedure
            fp = null;
            myOperation.con.Close();
        }

        private void PicEmp_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE| *.jpg; *.jpeg|PNG FILE|*.png|BMP FILE|*.bmp";
            fd.Title = "Open an image...";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picEmp.Image = Image.FromFile(fp);
            }
        }
    }
}