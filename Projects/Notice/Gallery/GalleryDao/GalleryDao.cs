using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notice.Gallery.GalleryEntity
{
    class GalleryDao
    {
        public static void Save(byte[] photo, DateTime createDate, string createBy, int? id = null)
        {
            try
            {
                SqlCommand cmd;
                if (id.Equals(null))
                {
                    cmd = new SqlCommand(
                        "INSERT INTO GALLERY(Photo,CreateDate,CreateBy) VALUES(@photo,@createDate,@createBy)",
                        Connection.ToDatabase());
                    cmd.Parameters.AddWithValue("@photo", SqlDbType.Image).Value = photo;
                    cmd.Parameters.AddWithValue("@createDate", SqlDbType.DateTime).Value = createDate;
                    cmd.Parameters.AddWithValue("@createBy", SqlDbType.NVarChar).Value = createBy;
                    cmd.ExecuteNonQuery();
                }
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
