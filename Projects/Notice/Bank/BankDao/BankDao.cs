using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notice.Income.BankEntity
{
    class BankDao
    {
        public static void SaveBank(DateTime? date, decimal amount, string type, string Des, DateTime? createDate, string cretaeBy, int? id = null)
        {
            try
            {
                string sql = string.Empty;
                if (id.Equals(null))
                {
                    sql = "INSERT INTO BANK([Date], Amount, Type, Description, CreateDate, CreateBy)  VALUES(" +
                          "'" +date + "','" + amount + "',"+ "N'" + type + "'," + "N'" + Des + "','" + createDate + "',N'" + cretaeBy + "')";
                }
                else
                {
                    sql = "UPDATE BANK SET " + "Amount = '" + amount + "', Description='" + Des + "', Date='" + date + "' WHERE ID=" + id;
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
