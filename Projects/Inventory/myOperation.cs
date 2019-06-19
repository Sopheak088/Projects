using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public class myOperation
    {
        public static SqlConnection con; //បង្កើត object ឈ្មោះ con ដើម្បីភ្ជាប់ទៅកាន់ database
        
        public static void myConnection() //បង្កើត method ឈ្មោះ myConnection
        {
            string conStr;
            conStr = "Data Source=.; Initial Catalog=Inventory; Integrated Security=true;";
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
                //MessageBox.Show("Successfull connected...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}