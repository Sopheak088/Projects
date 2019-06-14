using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notice.About
{
    class AboutDao
    {
        public static void SaveAbout(string note, DateTime? createDate, string cretaeBy, int? id = null)
        {
            try
            {
                string sql = String.Empty;
                if (id.Equals(null))
                {
                    sql = "INSERT INTO ABOUT(Note, CreateDate, CreateBy) VALUES(" +
                                 "N'"+ note +"','" + createDate + "',N'" + cretaeBy + "')";
                }
                else
                {
                    sql = "UPDATE ABOUT SET Note = N'" + note+"' WHERE ID="+id;
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
