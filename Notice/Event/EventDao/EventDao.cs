using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notice.Event.EventEntity
{
    class EventDao
    {
        public static void SaveEvent(DateTime? eventDate, string eventName, string Des, DateTime? createDate, string cretaeBy, int? id = null)
        {
            try
            {
                string sql = string.Empty;
                if (id.Equals(null))
                {
                    sql = "INSERT INTO [ALLEVENT](EventDate, EventName, Description, CreateDate, CreateBy) VALUES(" +
                          "'" + eventDate + "'," + "N'" + eventName + "'," + "N'" + Des + "','" + createDate + "',N'" + cretaeBy + "')";
                }
                else
                {
                    sql = "UPDATE [ALLEVENT] SET EventName = N'" + eventName + "', Description='" + Des + "',EventDate='" + eventDate + "' WHERE ID=" + id;
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
