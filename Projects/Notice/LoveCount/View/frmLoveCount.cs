using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Notice.LoveCount.LoveEntity;

namespace Notice.LoveCount.View
{
    public partial class frmLoveCount : Form
    {
        public frmLoveCount()
        {
            InitializeComponent();
        }

        private void frmLoveCount_Load(object sender, EventArgs e)
        {
            visible(false);
            try
            {
                LoadMale();
                LoadFemale();
            }
            catch (Exception ep)
            {
                throw ep;
            }
        }

        void LoadMale()
        {
            SqlDataAdapter adapter;
            DataTable dt;
            adapter = new SqlDataAdapter();
            dt = new DataTable();
            adapter.SelectCommand = new SqlCommand("SELECT ID,Name,Photo,StartDate,Status FROM LOVECOUNT WHERE status='Male'", Connection.ToDatabase());
            adapter.Fill(dt);
            if (!string.IsNullOrWhiteSpace(dt.Rows[0]["Name"].ToString()))
            {
                lblMale.Text = dt.Rows[0]["Name"].ToString();
            }
            Bitmap img;
            byte[] photo;
            if (!dt.Rows[0]["Photo"].Equals(DBNull.Value))
            {
                photo = (byte[])dt.Rows[0]["Photo"];
                MemoryStream ms = new MemoryStream(photo);
                img = new Bitmap(Image.FromStream(ms));
                picMale.Image = img;
            }

            DateTime startDate = (DateTime)dt.Rows[0]["StartDate"];

            //DateTime startDate = new DateTime(2018, 07, 29, 22, 18, 00);//29.07.2018 22:18PM
            DateTime toDate = DateTime.Today;

            lblTo.Text = toDate.ToString("dddd, dd MMMM yyyy");

            TimeSpan pv = toDate.Subtract(startDate);

            lblTotal.Text = (int)pv.TotalDays + "Days ";// + (int)pv.Hours + "h:" + (int)pv.Minutes + "m";

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Value = startDate;

            lblStart.Text = startDate.ToString("dddd, dd MMMM yyyy");
        }
        void LoadFemale()
        {
            SqlDataAdapter adapter;
            DataTable dt;
            adapter = new SqlDataAdapter();
            dt = new DataTable();
            adapter.SelectCommand = new SqlCommand("SELECT ID,Name,Photo,StartDate,Status FROM LOVECOUNT WHERE status='Female'", Connection.ToDatabase());
            adapter.Fill(dt);

            if (!string.IsNullOrWhiteSpace(dt.Rows[0]["Name"].ToString()))
            {
                lblFemale.Text = dt.Rows[0]["Name"].ToString();
            }

            Bitmap img;
            byte[] photo;
            if (!dt.Rows[0]["Photo"].Equals(DBNull.Value))
            {
                photo = (byte[])dt.Rows[0]["Photo"];
                MemoryStream ms = new MemoryStream(photo);
                img = new Bitmap(Image.FromStream(ms));
                picFemale.Image = img;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        void visible(bool isLoad)
        {
            btnUpdateMaleName.Visible = isLoad;
            txtMale.Visible = isLoad;
            txtFemale.Visible = isLoad;
            btnUpdateFemaleName.Visible = isLoad;
            btnUpdateMaleName.Visible = isLoad;
            dtpStartDate.Visible = isLoad;
            btnUpdateStartDate.Visible = isLoad;
        }

        private void lblMale_Click(object sender, EventArgs e)
        {
            txtMale.Visible = true;
            btnUpdateMaleName.Visible = true;
            txtMale.Focus();
        }

        private void lblFemale_Click(object sender, EventArgs e)
        {
            txtFemale.Visible = true;
            btnUpdateFemaleName.Visible = true;
            txtFemale.Focus();
        }

        private void pDisplay_Click(object sender, EventArgs e)
        {
            visible(false);
        }

        private void btnUpdateMaleName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMale.Text)) return;
            LoveCountDao.UpdateMaleName(txtMale.Text);
            lblMale.Text = txtMale.Text;
            visible(false);
        }

        private void btnUpdateFemaleName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFemale.Text)) return;
            LoveCountDao.UpdateFemaleName(txtFemale.Text);
            lblFemale.Text = txtFemale.Text;
            visible(false);
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            dtpStartDate.Visible = true;
            btnUpdateStartDate.Visible = true;
        }

        private void btnUpdateStartDate_Click(object sender, EventArgs e)
        {
            visible(false);
            lblStart.Text = dtpStartDate.Value.ToString("dddd, dd MMMM yyyy");
            LoveCountDao.UpdateStartDate(DateTime.Parse(dtpStartDate.Value.ToString("dd/MMMM/yyyy")));
            LoadMale();
        }

        private void picMale_Click(object sender, EventArgs e)
        {
            string fp;
            byte[] binpic;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All File | *.*| BMP FILE| *.bmp|JPEG FILE|.jgp; *.jpeg|PNG FILE| *.png";
            fd.Title = "Open an Image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                binpic = System.IO.File.ReadAllBytes(fp);
                MemoryStream ms = new MemoryStream(binpic);
                picMale.Image = Image.FromStream(ms);

                LoveCountDao.UpdateMalePhoto(binpic);
            }
        }

        private void picFemale_Click(object sender, EventArgs e)
        {
            string fp;
            byte[] binpic;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All File | *.*| BMP FILE| *.bmp|JPEG FILE|.jgp; *.jpeg|PNG FILE| *.png";
            fd.Title = "Open an Image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                binpic = System.IO.File.ReadAllBytes(fp);
                MemoryStream ms = new MemoryStream(binpic);
                picFemale.Image = Image.FromStream(ms);

                LoveCountDao.UpdateFemalePhoto(binpic);
            }
        }
    }
}
