using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pheak;
using Pheak.Database;

namespace Inventory.Connection
{
    public static class ConnectionDb
    {
        /// <summary>
        /// Connect has been Open already
        /// </summary>
        public static SqlConnection Connect = pConnection.connection(".", "SaleInventory");

        /* public static void MyConnection()
         {
             string conStr = ConfigurationManager.AppSettings["ConnectionName"];
             try
             {
                 Connect = new SqlConnection(conStr);
                 Connect.Open();
                 MessageBox.Show("Successfull connected...");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/
    }
}