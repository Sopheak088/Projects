using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notice.Report.View
{
    public partial class frmReport : Form
    {
        private decimal ownBankIn;
        private decimal ownBankOut;

        private decimal savingIn;
        private decimal savingOut;

        private decimal income;
        private decimal payment;
        private decimal balance;

        private int balanceRate;
        private int paymentRate;
        private int ownAccRate;
        private int savingAccRate;

        public frmReport()
        {
            InitializeComponent();
        }

        private void LoadIncome()
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand = new SqlCommand("SELECT SUM(Amount) Amount FROM INCOME", Connection.ToDatabase());
                adapter.Fill(dt);
                income = decimal.Parse(dt.Rows[0]["Amount"].ToString());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void LoadPayment()
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT SUM(Price) AS Amount FROM PAYMENT", Connection.ToDatabase());
                adapter.Fill(dt);
                payment = decimal.Parse(dt.Rows[0]["Amount"].ToString());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            pBalance.Value = 40;
            //Own bank
            LoadOwnBankIn();
            LoadOwnBankOut();
            lblOwnCahIin.Text = ownBankIn.ToString("$0.00");
            lblOwnCashOut.Text = ownBankOut.ToString("$0.00");

            //Income
            LoadIncome();
            lblIncome.Text = income.ToString("$0.00");

            //Payment
            LoadPayment();
            lblPayment.Text = payment.ToString("$0.00");
            lblPaid.Text = payment.ToString("$0.00");

            //Balance
            balance = income - payment;
            lblBalance.Text = balance.ToString("$0.00");
            //Bank Saving
            LoadBankSavingIn();
            LoadBankSavingOut();
            lblSavingIn.Text = savingIn.ToString("$0.00");
            lblSavingOut.Text = savingOut.ToString("$0.00");

            // ********** Rate
            //Payment
            paymentRate = (int)((payment / income) * 100);
            pPayment.Value = paymentRate;

            balanceRate = 100 - paymentRate;
            pBalance.Value = balanceRate;

            ownAccRate = (int)((ownBankOut / ownBankIn) * 100);
            pBankOwnAccount.Value = 100 - ownAccRate;

            if (!savingOut.Equals(0))
            {
                savingAccRate = 100 - (int)((savingOut / savingIn) * 100);
            }
            else
            {
                savingAccRate = 100;
            }
            pBankSavingAccount.Value = savingAccRate;
        }

        private void LoadBankSavingIn()
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT SUM(Amount) As Amount FROM BANK_SAVING WHERE Type ='Cash In'", Connection.ToDatabase());
                adapter.Fill(dt);
                savingIn = decimal.Parse(dt.Rows[0]["Amount"].ToString());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void LoadBankSavingOut()
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT SUM(Amount) As Amount FROM BANK_SAVING WHERE Type ='Cash Out'", Connection.ToDatabase());
                adapter.Fill(dt);
                savingOut = decimal.Parse(dt.Rows[0]["Amount"].ToString());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void LoadOwnBankIn()
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT SUM(Amount) As Amount FROM BANK WHERE Type ='Cash In'", Connection.ToDatabase());
                adapter.Fill(dt);
                ownBankIn = decimal.Parse(dt.Rows[0]["Amount"].ToString());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void LoadOwnBankOut()
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT SUM(Amount) As Amount FROM BANK WHERE Type ='Cash Out'", Connection.ToDatabase());
                adapter.Fill(dt);
                ownBankOut = decimal.Parse(dt.Rows[0]["Amount"].ToString());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}