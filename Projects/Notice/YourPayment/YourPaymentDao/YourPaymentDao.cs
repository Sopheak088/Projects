using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notice.YourPayment.YourPaymentEntity
{
    class YourPaymentDao
    {
        public static void SavePayment(DateTime? paymentDate, string items, decimal price,string Des,  DateTime? createDate, string cretaeBy, int? id = null)
        {
            try
            {
                string sql = string.Empty;
                if (id.Equals(null))
                {
                    sql = "INSERT INTO YOURPAYMENT(PaymentDate, Items, Price, Description, CreateDate, CreateBy) VALUES(" +
                                 "'"+paymentDate +"'," + "N'" + items +"','" + price + "'," + "N'" + Des + "','" + createDate + "',N'" + cretaeBy + "')";
                }
                else
                {
                    sql = "UPDATE YOURPAYMENT SET Items = N'" + items + "', Price = '"+ price + "', Description='"+ Des + "',PaymentDate='"+ paymentDate + "' WHERE ID=" + id;
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
