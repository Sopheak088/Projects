using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.SqlServer.Server;
using Pheak.GridEx;

namespace Notice.Event.View
{
    public partial class frmEvent : Form
    {
        private int? id;

        public frmEvent()
        {
            InitializeComponent();
            gridListEvent.RootTable.Columns["EventDate"].FormatString = String.Format("dd/MMMM/yyyy");
        }

        private void frmEvent_Load(object sender, EventArgs e)
        {
            visible(true);
            refresh();
        }

        private void refresh()
        {
            id = null;
            pGridEX.BindDataIntoGrid(Connection.ToDatabase(), "ListAllEvent", gridListEvent);
            foreach (GridEXRow row in gridListEvent.GetRows())
            {
                DateTime dtpEvent = DateTime.Parse(row.Cells["EventDate"].Value.ToString());
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
                    GridEXFormatStyle style = new GridEXFormatStyle();
                    style.BackColor = Color.Green;
                    row.Cells["EventDate"].FormatStyle = style;
                    row.Cells["EventName"].FormatStyle = style;
                    row.Cells["FromNow"].FormatStyle = style;
                    row.Cells["FromNow"].Text = "Very Nice";
                    //MessageBox.Show(@"OK Nice");
                }
                else
                {
                    row.Cells["FromNow"].Text = (t.Days).ToString();
                    //MessageBox.Show((t.Days).ToString());
                }
            }
        }

        private void visible(bool isLoad)
        {
            btnSave.Visible = !isLoad;
            lblPaymentDate.Visible = !isLoad;
            lblItems.Visible = !isLoad;
            lblDes.Visible = !isLoad;
            dtpEvent.Visible = !isLoad;
            txtEventName.Visible = !isLoad;
            txtDescription.Visible = !isLoad;

            btnNew.Visible = isLoad;
            gridListEvent.Visible = isLoad;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (gridListEvent.Visible) Close();
            else visible(true);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            visible(false);
            txtEventName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dtpEvent.Value = DateTime.Today;
            txtEventName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventName.Text)) return;
            string eventName = txtEventName.Text;
            string des = txtDescription.Text;
            DateTime eventDate = DateTime.Parse(dtpEvent.Value.ToString("dd/MMMM/yyyy"));
            if (id.Equals(null))
            {
                EventEntity.EventDao.SaveEvent(eventDate, eventName, des, myClass.createDate, myClass.createBy);
            }
            else
            {
                EventEntity.EventDao.SaveEvent(eventDate, eventName, des, myClass.createDate, myClass.createBy, id);
            }
            visible(true);
            Refresh();
        }

        private void gridListPayment_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT * FROM [ALLEVENT] WHERE ID=" + gridListEvent.GetRow().Cells["ID"].Value,
                        Connection.ToDatabase());
                adapter.Fill(dt);
                id = int.Parse(dt.Rows[0]["ID"].ToString());
                txtEventName.Text = dt.Rows[0]["EventName"].ToString();
                txtDescription.Text = dt.Rows[0]["Description"].ToString();
                visible(false);
                DateTime dtp = (DateTime)dt.Rows[0]["EventDate"];
                dtpEvent.Format = DateTimePickerFormat.Custom;
                dtpEvent.CustomFormat = "dd/MM/yyyy";
                dtpEvent.Value = dtp;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void gridListEvent_FormattingRow(object sender, RowLoadEventArgs e)
        {
        }
    }
}