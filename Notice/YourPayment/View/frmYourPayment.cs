using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Pheak.GridEx;

namespace Notice.YourPayment.View
{
    public partial class frmYourPayment : Form
    {
        private int? id;
        public frmYourPayment()
        {
            InitializeComponent();
            gridListPayment.RootTable.Columns["PaymentDate"].FormatString = String.Format("dd/MMMM/yyyy");
            gridListPayment.RootTable.Columns["Price"].FormatString = String.Format("$0.00");
            gridListPayment.RootTable.Columns["Price"].TotalFormatString = String.Format("$0.00");
        }

        private void frmYourPayment_Load(object sender, EventArgs e)
        {
            visible(true);
            refresh();
        }

        void refresh()
        {
            id = null;
            pGridEX.BindDataIntoGrid(Connection.ToDatabase(), "ListAllYourPayment", gridListPayment);
        }
        void visible(bool isLoad)
        {
            btnSave.Visible = !isLoad;
            lblPaymentDate.Visible = !isLoad;
            lblItems.Visible = !isLoad;
            lblPrice.Visible = !isLoad;
            lblDes.Visible = !isLoad;
            dtpPayment.Visible = !isLoad;
            txtItems.Visible = !isLoad;
            txtPrice.Visible = !isLoad;
            txtDescription.Visible = !isLoad;

            btnNew.Visible = isLoad;
            gridListPayment.Visible = isLoad;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(gridListPayment.Visible) Close();
            else visible(true);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            visible(false);
            txtItems.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dtpPayment.Value = DateTime.Today;
            txtItems.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text) && string.IsNullOrWhiteSpace(txtItems.Text)) return;
            string items = txtItems.Text;
            decimal price = 0;
            int n = Int16.Parse(txtPrice.Text.Length.ToString());
            if (txtPrice.Text.Substring(0, 1) == "$")
                price = decimal.Parse(txtPrice.Text.Substring(1, n - 1));
            else
            {
                price = decimal.Parse(txtPrice.Text);
            }
            string des = txtDescription.Text;
            DateTime paymentDate = DateTime.Parse(dtpPayment.Value.ToString("dd/MMMM/yyyy"));
            if (id.Equals(null))
            {
                YourPaymentEntity.YourPaymentDao.SavePayment(paymentDate, items, price, des, myClass.createDate, myClass.createBy);
            }
            else
            {
                YourPaymentEntity.YourPaymentDao.SavePayment(paymentDate, items, price, des, myClass.createDate, myClass.createBy,id);
            }
            visible(true);
            Refresh();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pheak.myOper.Textbox_Only_Number_KeyPress(txtPrice,sender,e);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            Pheak.myClass.Textbox_Leave_Currency(txtPrice);
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            Pheak.myClass.Textbox_Enter_Number(txtPrice);
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
                    new SqlCommand("SELECT * FROM YOURPAYMENT WHERE ID=" + gridListPayment.GetRow().Cells["ID"].Value,
                        Connection.ToDatabase());
                adapter.Fill(dt);
                id = int.Parse(dt.Rows[0]["ID"].ToString());
                txtItems.Text = dt.Rows[0]["Items"].ToString();
                txtPrice.Text = string.Format("{0:C}", dt.Rows[0]["Price"].ToString());
                txtDescription.Text = dt.Rows[0]["Description"].ToString();
                visible(false);
                DateTime dtp = (DateTime) dt.Rows[0]["PaymentDate"];
                dtpPayment.Format = DateTimePickerFormat.Custom;
                dtpPayment.CustomFormat = "dd/MM/yyyy";
                dtpPayment.Value = dtp;
            }
            catch (Exception exception)
            {
                return;
            }
        }
    }
}
