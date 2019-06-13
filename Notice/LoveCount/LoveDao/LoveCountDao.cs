using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notice.LoveCount.LoveEntity
{
    class LoveCountDao
    {
        public static void UpdateMaleName(string name)
        {
            string sql;
            sql = "UPDATE LOVECOUNT SET Name = N'" + name + "' WHERE Status='Male'";
            UpdateLoveCount(sql);
        }
        public static void UpdateFemaleName(string name)
        {
            string sql;
            sql = "UPDATE LOVECOUNT SET Name = N'" + name + "' WHERE Status='Female'";
            UpdateLoveCount(sql);
        }
        public static void UpdateMalePhoto(byte[] photo)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE LOVECOUNT SET Photo = @photo WHERE Status='Male'", Connection.ToDatabase());
                cmd.Parameters.AddWithValue("@photo", SqlDbType.Image).Value = photo;
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
        public static void UpdateFemalePhoto(byte[] photo)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE LOVECOUNT SET Photo = @photo WHERE Status='Female'", Connection.ToDatabase());
                cmd.Parameters.AddWithValue("@photo", SqlDbType.Image).Value = photo;
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
        public static void UpdateStartDate(DateTime startDate)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE LOVECOUNT SET StartDate = @startDate", Connection.ToDatabase());
                cmd.Parameters.AddWithValue("@startDate", SqlDbType.NVarChar).Value = startDate;
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

        public static void UpdateLoveCount(string sql)
        {
            try
            {
                
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
