using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; 

namespace Notice.About.View
{
    public partial class frmAbout : Form
    {
        private int? id;
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            txtNote.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT * FROM ABOUT", Connection.ToDatabase());
                adapter.Fill(dt);
                id = int.Parse(dt.Rows[0]["ID"].ToString());

                txtNote.Text = dt.Rows[0]["Note"].ToString();
            }
            catch (Exception exception)
            {
                return;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                return;
            }
            string note = txtNote.Text;
            if (id.Equals(null))
            {
                AboutDao.SaveAbout(note, myClass.createDate, myClass.createBy);
            }
            else
            {
                AboutDao.SaveAbout(note, myClass.createDate, myClass.createBy,id);
            }
            LoadData();
            btnSave.Visible = false;
            txtNote.Enabled = false;
        }

        private void btnEditOffOn_OnValueChange(object sender, EventArgs e)
        {
            btnSave.Visible = btnEditOffOn.Value;
            txtNote.Enabled = btnEditOffOn.Value;
            if (btnEditOffOn.Value) txtNote.Focus();
        }
    }
}
