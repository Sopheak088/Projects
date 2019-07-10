using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Inventory.Employee.View
{
    public partial class FrmEmployee : Form
    {
        private Boolean b;
        private SqlCommand com;
        private byte[] photo;
        private SqlDataAdapter da;
        private string fp;
        private DataTable dt;
        private DialogResult re1;

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM dbo.GetEmployee()", Myoperation.con);
            dt = new DataTable();
            da.Fill(dt);
            dgvEmp.DataSource = dt;
            dgvEmp.ColumnHeadersDefaultCellStyle.Font = new Font("Time News Roman", 14, FontStyle.Bold);
            dgvEmp.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvEmp.Columns["Name"].Width = 200;
            dgvEmp.Columns["BirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEmp.Columns["Hired Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEmp.Columns["Salary"].DefaultCellStyle.Format = "c";

            //define image size stretch
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvEmp.Columns["Photo"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            foreach (DataGridViewColumn col in dgvEmp.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            // clear select item in data
            dgvEmp.ClearSelection();
            dt.Dispose(); // close datatable
            da.Dispose(); // close dataAdapter
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            Myoperation.myConnection();
            Myoperation.Onoff(this, false);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search ID or Name here....";
            LoadData();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")

            {
                b = true;
                Myoperation.Onoff(this, true);
                btnNew.Text = "Cancel";
                btnNew.Image = Inventory.Properties.Resources.do_not_disturb_25px;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                txtID.Focus();
            }
            else
            {
                DialogResult re = DialogResult.Yes;
                re = MessageBox.Show("Do you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    Myoperation.ClearData(this);
                    Myoperation.Onoff(this, false);
                    btnNew.Text = "New";
                    btnNew.Image = Inventory.Properties.Resources.edit_property_25px;
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Do you want to close??", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = "dd/MM/yyyy";
        }

        private void DtpHired_ValueChanged(object sender, EventArgs e)
        {
            dtpHired.CustomFormat = "dd/MM/yyyy";
        }

        private void TxtSalary_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalary.Text) || !string.IsNullOrWhiteSpace(txtSalary.Text))
                txtSalary.Text = string.Format("{0:C}", Decimal.Parse(txtSalary.Text));
        }

        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal x;
            char ch = e.KeyChar;
            if (ch == (char)8)//backspace
                e.Handled = false;
            else if (!char.IsDigit(ch) && ch != '.' || !decimal.TryParse(txtSalary.Text + ch, out x))
                e.Handled = true;
        }

        private void TxtSalary_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalary.Text) || !string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                var s = decimal.Parse(txtSalary.Text, NumberStyles.Currency);
                txtSalary.Text = s.ToString();
            }
        }

        private void DtpDOB_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("%{DOWN}");
        }

        private void DtpHired_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("%{DOWN}");
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search ID or Name here....")
            {
                txtSearch.Text = null;
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.Text = "Search ID or Name here....";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void Modify(string X)
        {
            var salary = decimal.Parse(txtSalary.Text, NumberStyles.Currency);
            com = new SqlCommand(X, Myoperation.con);
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
            com.ExecuteNonQuery();
            fp = null;
            Myoperation.ClearData(this);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                re1 = MessageBox.Show("Please input ID...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please input Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }
            if (rdoFemale.Checked == false && rdoMale.Checked == false)
            {
                MessageBox.Show("Please Select Gender", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rdoFemale.Focus();
                return;
            }
            if (dtpDOB.CustomFormat == " ")
            {
                MessageBox.Show("Please select Birthdate... ", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDOB.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPos.Text.Trim()))
            {
                MessageBox.Show("Please input Position");
                SendKeys.Send("%{DOWN}");
                txtPos.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSalary.Text.Trim()))
            {
                MessageBox.Show("Please input Salary", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalary.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Please input Address", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                MessageBox.Show("PLease input PhoneNumber", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return;
            }
            if (dtpHired.CustomFormat == " ")
            {
                MessageBox.Show("Please input Hired...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpHired.Focus();
                SendKeys.Send("%{DOWN}");
                return;
            }
            if (picEmp.Image == null)
            {
                MessageBox.Show("Please select an image...");
                PicEmp_Click(sender, e); // what does it mean??
                //when image null it calls this method ok
            }
            if (b == true)
            {
                Modify("InsertEmployee");
                MessageBox.Show("Your data was saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Modify("UpdateEmployee");
                MessageBox.Show("Your data was update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //  FrmEmployee_Load(sender, e);
            Myoperation.Onoff(this, false);
            LoadData();
            btnNew.Text = "New";
            btnNew.Image = Inventory.Properties.Resources.edit_property_25px;
        }

        private void PicEmp_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE|*.jpg; *.jpeg|PNG FILE|*.png";
            fd.Title = "Open an Image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picEmp.Image = Image.FromFile(fp);
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            Myoperation.ConStrToTitle(txtName);
        }

        private void TxtPos_Leave(object sender, EventArgs e)
        {
            Myoperation.ConStrToTitle(txtPos);
        }

        private void TxtID_KeyUp(object sender, KeyEventArgs e)
        {
            if (re1 == DialogResult.OK)
                return;
            Myoperation.KeyControl(this, sender, e);
        }

        private void DgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvEmp.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                if (btnNew.Text == "Cancel" && btnSave.Enabled == true)
                    return;

                DataGridViewRow row = dgvEmp.Rows[i];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "F")
                    rdoFemale.Checked = true;
                else
                    rdoMale.Checked = true;
                dtpDOB.CustomFormat = "dd/MM/yyyy";
                dtpDOB.Text = row.Cells[3].Value.ToString();
                txtPos.Text = row.Cells[4].Value.ToString();
                txtSalary.Text = string.Format("{0:C}", row.Cells[5].Value.ToString());
                txtAddress.Text = row.Cells[6].Value.ToString();
                txtPhone.Text = row.Cells[7].Value.ToString();
                dtpHired.CustomFormat = "dd/MM/yyyy";
                dtpHired.Text = row.Cells[8].Value.ToString();

                //read byte from datagrideview
                photo = (byte[])row.Cells[9].Value;
                MemoryStream ms = new MemoryStream(photo);
                picEmp.Image = Image.FromStream(ms);

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            btnNew.Text = "Cancel";
            btnNew.Image = Inventory.Properties.Resources.do_not_disturb_25px;
            Myoperation.Onoff(this, true);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtID.Enabled = false;
            txtName.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Do you want to delete", " Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Modify("DeleteEmployee");
                Myoperation.ClearData(this);
                MessageBox.Show("Your record was deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmEmployee_Load(sender, e);
            }
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("SearchEmpbyName", Myoperation.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@s", txtSearch.Text);
            //Becuz we search by this textbox

            da = new SqlDataAdapter(); //ផ្តើមតំបន់អោយda
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);
            dgvEmp.DataSource = dt;

            if (dt.Rows.Count < 1)
            {
                DataTable dataTable = new DataTable();
                string sqlSelectQuery =
                "SELECT empID as [ID], empName as [Name], empGender as [Gender]," +
                "dob as [BirthDate], pos as [Position], salary as [Salary]," +
                "[address] as [Address],empContact as [Contact],hired as [Hired Date], " +
                "photo as [Photo] FROM tbEmployee where empID like '%" +
                txtSearch.Text + "%' AND stopwork = 'false'";

                try
                {
                    SqlCommand cmd = new SqlCommand(sqlSelectQuery, Myoperation.con);
                    // create data adapter
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // this will query your database and return the result to your datatable
                    da.Fill(dataTable);
                    dgvEmp.DataSource = dataTable;
                    da.Dispose();
                }
                finally
                {
                    Myoperation.con.Close();
                }
                //com = new SqlCommand("SearchEmpbyID", Myoperation.con);
                //com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.AddWithValue("@s", txtSearch.Text);

                //da = new SqlDataAdapter();
                //da.SelectCommand = com;
                //dt = new DataTable();
                //da.Fill(dt);
                //dgvEmp.DataSource = dt;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}