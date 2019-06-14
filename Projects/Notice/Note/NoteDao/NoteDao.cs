using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notice.Note
{
    class NoteDao
    {
        public static void SaveNote(string note,DateTime? noteDate, DateTime? createDate, string cretaeBy, int? id = null)
        {
            try
            {
                string sql = String.Empty;
                if (id.Equals(null))
                {
                    sql = "INSERT INTO NOTE(Note, NoteDate, CreateDate, CreateBy) VALUES(" +
                                 "N'"+ note +"','"+ noteDate + "','" + createDate + "',N'" + cretaeBy + "')";
                    /*cmd = new SqlCommand("INSERT INTO NOTE(Note, NoteDate, CreateDate, CreateBy) Values(@note, @noteDate,@createDate,@createBy)", ToDatabase());
                    cmd.Parameters.AddWithValue("@note", SqlDbType.NVarChar).Value = note;
                    cmd.Parameters.AddWithValue("@noteDate", SqlDbType.DateTime).Value = noteDate;
                    cmd.Parameters.AddWithValue("@createDate", SqlDbType.DateTime).Value = noteDate;
                    cmd.Parameters.AddWithValue("@createBy", SqlDbType.NVarChar).Value = note;
                    cmd.ExecuteNonQuery();*/
                }
                else
                {
                    sql = "UPDATE NOTE SET Note = N'"+note+"', NoteDate ='"+noteDate+"' WHERE ID="+id;
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
