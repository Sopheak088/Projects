using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notice.Payment.PaymentEntity
{
    class PaymentDao
    {
        public static void SavePayment(DateTime? paymentDate, string items, decimal price,string Des,  DateTime? createDate, string createBy, int? id = null)
        {
            try
            {
                string sql = string.Empty;
                if (id.Equals(null))
                {
                    sql = "INSERT INTO PAYMENT(PaymentDate, Items, Price, Description, CreateDate, CreateBy) VALUES(" +
                                 "'"+paymentDate +"'," + "N'" + items +"','" + price + "'," + "N'" + Des + "','" + createDate + "',N'" + createBy + "')";
                }
                else
                {
                    sql = "UPDATE PAYMENT SET Items = N'"+ items + "', Price = '"+ price + "', Description='"+ Des + "',PaymentDate='"+ paymentDate + "' WHERE ID=" + id;
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
