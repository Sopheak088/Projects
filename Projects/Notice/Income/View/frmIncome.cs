using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Notice.Income.IncomeEntity;
using Pheak.GridEx;

namespace Notice.Incomes.View
{
    public partial class frmIncome : Form
    {
        private int? id;
        public frmIncome()
        {
            InitializeComponent();
            gridListPayment.RootTable.Columns["IncomeDate"].FormatString = String.Format("dd/MMMM/yyyy");
            gridListPayment.RootTable.Columns["Amount"].FormatString = String.Format("$0.00");
            gridListPayment.RootTable.Columns["Amount"].TotalFormatString = String.Format("$0.00");
        }

        private void frmIncome_Load(object sender, EventArgs e)
        {
            visible(true);
            refresh();
        }

        void refresh()
        {
            id = null;
            pGridEX.BindDataIntoGrid(Connection.ToDatabase(), "ListAllIncome", gridListPayment);
        }
        void visible(bool isLoad)
        {
            btnSave.Visible = !isLoad;
            lblPaymentDate.Visible = !isLoad;
            lblFrom.Visible = !isLoad;
            lblPrice.Visible = !isLoad;
            lblDes.Visible = !isLoad;
            dtpIncome.Visible = !isLoad;
            txtSupplier.Visible = !isLoad;
            txtAmount.Visible = !isLoad;
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
            txtSupplier.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dtpIncome.Value = DateTime.Today;
            txtAmount.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text) && string.IsNullOrWhiteSpace(txtSupplier.Text)) return;
            string from = txtSupplier.Text;
            decimal amount = 0;
            int n = Int16.Parse(txtAmount.Text.Length.ToString());
            if (txtAmount.Text.Substring(0, 1) == "$")
                amount = decimal.Parse(txtAmount.Text.Substring(1, n - 1));
            else
            {
                amount = decimal.Parse(txtAmount.Text);
            }
            string des = txtDescription.Text;
            DateTime incomeDate = DateTime.Parse(dtpIncome.Value.ToString("dd/MMMM/yyyy"));
            if (id.Equals(null))
            {
                IncomeDao.SaveIncome(incomeDate, from, amount, des, myClass.createDate, myClass.createBy);
            }
            else
            {
                IncomeDao.SaveIncome(incomeDate, from, amount, des, myClass.createDate, myClass.createBy,id);
            }
            visible(true);
            Refresh();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pheak.myOper.Textbox_Only_Number_KeyPress(txtAmount,sender,e);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            Pheak.myClass.Textbox_Leave_Currency(txtAmount);
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            Pheak.myClass.Textbox_Enter_Number(txtAmount);
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
                    new SqlCommand("SELECT * FROM INCOME WHERE ID=" + gridListPayment.GetRow().Cells["ID"].Value,
                        Connection.ToDatabase());
                adapter.Fill(dt);
                id = int.Parse(dt.Rows[0]["ID"].ToString());
                txtSupplier.Text = dt.Rows[0]["IncomeFrom"].ToString();
                txtAmount.Text = string.Format("{0:C}", dt.Rows[0]["Amount"].ToString());
                txtDescription.Text = dt.Rows[0]["Description"].ToString();
                visible(false);
                DateTime dtp = (DateTime) dt.Rows[0]["IncomeDate"];
                dtpIncome.Format = DateTimePickerFormat.Custom;
                dtpIncome.CustomFormat = "dd/MM/yyyy";
                dtpIncome.Value = dtp;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
