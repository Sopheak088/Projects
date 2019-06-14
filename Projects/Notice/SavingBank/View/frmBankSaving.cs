using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pheak.GridEx;

namespace Notice.SavingBank.View
{
    public partial class frmBankSaving : Form
    {
        public frmBankSaving()
        {
            InitializeComponent();
            gridListBank.RootTable.Columns["Date"].FormatString = String.Format("dd/MMMM/yyyy");
            gridListBank.RootTable.Columns["Amount"].FormatString = String.Format("$0.00");
            gridListBank.RootTable.Columns["Amount"].TotalFormatString = String.Format("$0.00");
        }

        private int? id;
        private void frmBankSaving_Load(object sender, EventArgs e)
        {
            visible();
            refresh();
        }
        void ClearData()
        {
            txtAmount.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
        }
        void refresh()
        {
            id = null;
            pGridEX.BindDataIntoGrid(Connection.ToDatabase(), "ListAllBankSaving", gridListBank);
        }
        void visible(bool isLoad = false)
        {
            pDisplay.Visible = !isLoad;
            btnSave.Visible = isLoad;
            btnCashIn.Visible = !isLoad;
            btnCashOut.Visible = !isLoad;
            //gridListBank.Visible = !isLoad;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (gridListBank.Visible) Close();
            else
            {
                gridListBank.Visible = true;
                btnCashIn.Text = "Cash In";
                btnCashOut.Text = "Cash Out";
                visible();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAmount.Text)) return;
            decimal amount = 0;
            int n = Int16.Parse(txtAmount.Text.Length.ToString());
            if (txtAmount.Text.Substring(0, 1) == "$")
                amount = decimal.Parse(txtAmount.Text.Substring(1, n - 1));
            else
            {
                amount = decimal.Parse(txtAmount.Text);
            }
            DateTime date = DateTime.Parse(dtpDate.Value.ToString("dd/MMMM/yyyy"));
            string des = txtDescription.Text;

            if (btnCashIn.Text.Equals("Cash In") && btnCashOut.Text.Equals("Cancel"))
            {
                if (id.Equals(null))
                {
                    SavingBankEntity.SavingBankDao.SaveBank(date,amount,myClass.CASH_IN,des,myClass.createDate,myClass.createBy);
                }
                else
                {
                    SavingBankEntity.SavingBankDao.SaveBank(date, amount, myClass.CASH_IN, des, myClass.createDate, myClass.createBy, id);
                }
            }
            else
            {
                if (id.Equals(null))
                {
                    SavingBankEntity.SavingBankDao.SaveBank(date, amount, myClass.CASH_OUT, des, myClass.createDate, myClass.createBy);
                }
                else
                {
                    SavingBankEntity.SavingBankDao.SaveBank(date, amount, myClass.CASH_OUT, des, myClass.createDate, myClass.createBy, id);
                }
            }
            frmBankSaving_Load(sender, e);
            gridListBank.Visible = true;
            btnCashIn.Text = "Cash In";
            btnCashOut.Text = "Cash Out";
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            id = null;
            if (btnCashIn.Text == "Cancel")
            {
                btnCashIn.Text = "Cash In";
                btnCashOut.Text = "Cash Out";
                gridListBank.Visible = true;
                visible();
            }
            else
            {
                ClearData();
                gridListBank.Visible = false;
                btnCashIn.Text = "Cash In";
                pDisplay.Visible = true;
                btnCashOut.Text = "Cancel";
                btnSave.Visible = true;
            }
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            id = null;
            if (btnCashOut.Text == "Cancel")
            {
                gridListBank.Visible = true;
                btnCashIn.Text = "Cash In";
                btnCashOut.Text = "Cash Out";
                visible();
            }
            else
            {
                ClearData();
                gridListBank.Visible = false;
                btnCashOut.Text = "Cash Out";
                pDisplay.Visible = true;
                btnCashIn.Text = "Cancel";
                btnSave.Visible = true;
            }
        }

        private void gridListBank_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand = new SqlCommand("SELECT * FROM BANK_SAVING WHERE ID=" + gridListBank.GetRow().Cells["ID"].Value, Connection.ToDatabase());
                adapter.Fill(dt);
                id = int.Parse(dt.Rows[0]["ID"].ToString());
                txtAmount.Text = string.Format("{0:C}", dt.Rows[0]["Amount"].ToString());
                txtDescription.Text = dt.Rows[0]["Description"].ToString();
                DateTime dtp = (DateTime)dt.Rows[0]["Date"];
                dtpDate.Format = DateTimePickerFormat.Custom;
                dtpDate.CustomFormat = "dd/MM/yyyy";
                dtpDate.Value = dtp;
                gridListBank.Visible = false;
                btnSave.Visible = true;
                if (gridListBank.GetRow().Cells["Type"].Value.Equals(myClass.CASH_IN))
                {
                    btnCashIn.Text = "Cash In";
                    btnCashOut.Text = "Cancel";
                }
                else
                {
                    btnCashIn.Text = "Cancel";
                    btnCashOut.Text = "Cash In";
                }
            }
            catch(Exception exception)

            {
                return;
            }
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pheak.myOper.Textbox_Only_Number_KeyPress(txtAmount, sender, e);
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            Pheak.myClass.Textbox_Leave_Currency(txtAmount);
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            Pheak.myClass.Textbox_Enter_Number(txtAmount);
        }
    }
}
