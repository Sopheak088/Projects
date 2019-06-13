using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notice.Income.IncomeEntity
{
    class IncomeDao
    {
        public static void SaveIncome(DateTime? incomeDate, string from, decimal amount,string Des,  DateTime? createDate, string cretaeBy, int? id = null)
        {
            try
            {
                string sql = string.Empty;
                if (id.Equals(null))
                {
                    sql = "INSERT INTO INCOME(IncomeDate,IncomeFrom, Amount,Description,CreateDate,CreateBy) VALUES(" +
                                 "'"+incomeDate +"'," + "N'" + from +"','" + amount + "'," + "N'" + Des + "','" + createDate + "',N'" + cretaeBy + "')";
                }
                else
                {
                    sql = "UPDATE INCOME SET IncomeFrom = N'" + from + "', Amount = '" + amount + "', Description='"+ Des + "',IncomeDate='" + incomeDate + "' WHERE ID=" + id;
                }
                SqlCommand cmd = new SqlCommand(sql, Connection.ToDatabase());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.ToDatabase().Close();
            }
        }
    }
}
