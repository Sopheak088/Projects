using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notice.SavingBank.SavingBankEntity
{
    class SavingBankDao
    {
        public static void SaveBank(DateTime? date, decimal amount, string type, string Des, DateTime? createDate, string cretaeBy, int? id = null)
        {
            try
            {
                string sql = string.Empty;
                if (id.Equals(null))
                {
                    sql = "INSERT INTO BANK_SAVING([Date], Amount, Type, Description, CreateDate, CreateBy)  VALUES(" +
                          "'" + date + "','" + amount + "'," + "N'" + type + "'," + "N'" + Des + "','" + createDate + "',N'" + cretaeBy + "')";
                }
                else
                {
                    sql = "UPDATE BANK_SAVING SET " + "Amount = '" + amount + "', Description='" + Des + "', Date='" + date + "' WHERE ID=" + id;
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
