using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pheak.Database;
using Pheak.CryptorEngine;

namespace Notice
{
    internal class Connection
    {
        public static SqlConnection ToDatabase()
        {
            SqlConnection con = null;
            try
            {
                con = pConnection.connection(".", "DBNOTICE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return con;
        }
    }
}