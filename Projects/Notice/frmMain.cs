using System;
using System.Windows.Forms;
using Notice.Gallery.View;
using Notice.Payment.View;
using Notice.YourPayment.View;
using Pheak;
using Notice.Bank.View;
using Notice.Event.View;
using Notice.Incomes.View;
using Notice.SavingBank.View;
using System.Data.SqlClient;
using System.Data;
using Notice.About.View;

namespace Notice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
            pLoading.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void visible(bool isLoad = false)
        {
            btnYourPayment.Visible = isLoad;
            btnGallery.Visible = isLoad;
            btnLove.Visible = isLoad;
            btnNote.Visible = isLoad;
            btnPayment.Visible = isLoad;
            btnBank.Visible = isLoad;
            btnCashIncome.Visible = isLoad;
            btnReport.Visible = isLoad;
            btnBankSaving.Visible = isLoad;
            lblTime.Visible = isLoad;
            btnEvent.Visible = isLoad;
            lblEvent.Visible = isLoad;
            btnAbout.Visible = isLoad;
        }

        public void ClearPanel()
        {
            if (!pLoading.Controls.Equals(null))
            {
                pLoading.Controls.Clear();
            }
            pLoading.Visible = false;
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            pLoading.Visible = false;
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            CheckEvent();
        }

        private void CheckEvent()
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT EventDate, EventName FROM ALLEVENT", Connection.ToDatabase());
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DateTime dtpEvent = (DateTime)dt.Rows[i]["EventDate"];
                    DateTime dtpNow = DateTime.Today;
                    TimeSpan t = new TimeSpan();
                    if (dtpEvent < dtpNow)
                    {
                        while (dtpEvent < dtpNow)
                        {
                            dtpEvent = dtpEvent.AddYears(1);
                        }
                    }
                    t = dtpEvent - dtpNow;
                    if (t.Days.Equals(0))
                    {
                        lblEvent.Visible = true;
                        lblEvent.Text = "Today is " + dt.Rows[i]["EventName"].ToString();
                        return;
                    }
                    else
                    {
                        lblEvent.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            pMoveForm.MouseDown(e);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            pMoveForm.MouseMove(this, e);
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            pMoveForm.MouseUp();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            visible();
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            Note.View.frmLoveCount s = new Note.View.frmLoveCount();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void pLoading_MouseMove(object sender, MouseEventArgs e)
        {
            pLoading.Visible = false;
            visible(true);
            CheckEvent();
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            visible();
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            Notice.LoveCount.View.frmLoveCount s = new Notice.LoveCount.View.frmLoveCount();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            visible();
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            frmPayment s = new frmPayment();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            visible();
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            frmGallery s = new frmGallery();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void btnYourPayment_Click(object sender, EventArgs e)
        {
            visible();
            btnYourPayment.Visible = false;
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            frmYourPayment s = new frmYourPayment();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            visible();
            btnYourPayment.Visible = false;
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            frmBank s = new frmBank();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void btnCashIncome_Click(object sender, EventArgs e)
        {
            visible();
            btnYourPayment.Visible = false;
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            frmIncome s = new frmIncome();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //visible();
            //btnYourPayment.Visible = false;
            //pLoading.Controls.Clear();
            //pLoading.Width = 316;
            //pLoading.Height = 575;
            //frmReport s = new frmReport();
            //s.TopLevel = false;
            //s.AutoScroll = true;
            //pLoading.Controls.Add(s);
            ////pLoading.Dock = DockStyle.Top;//Fill;
            //pLoading.Visible = true;
            //s.Show();
        }

        private void btnBankSaving_Click(object sender, EventArgs e)
        {
            visible();
            btnYourPayment.Visible = false;
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            frmBankSaving s = new frmBankSaving();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            visible();
            btnYourPayment.Visible = false;
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            frmEvent s = new frmEvent();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            visible();
            btnYourPayment.Visible = false;
            pLoading.Controls.Clear();
            pLoading.Width = 316;
            pLoading.Height = 575;
            frmAbout s = new frmAbout();
            s.TopLevel = false;
            s.AutoScroll = true;
            pLoading.Controls.Add(s);
            //pLoading.Dock = DockStyle.Top;//Fill;
            pLoading.Visible = true;
            s.Show();
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}