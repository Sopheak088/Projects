using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Inventory
{
    public class Myoperation
    {
        public static SqlConnection con;

        public static void myConnection()
        {
            string conStr;
            conStr = "Data Source=.; Initial Catalog=Inventory;  Integrated Security= true;";
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                //MessageBox.Show("Successed");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void Onoff(Form frm, Boolean b)
        {
            foreach (Control ct in frm.Controls)
                if (!(ct is Label))
                    if (ct.Tag == null)
                        ct.Enabled = b;
        }

        public static void ClearData(Form frm)
        {
            foreach (Control ct in frm.Controls)
            {
                if (ct is TextBox || ct is MaskedTextBox || ct is ComboBox)
                {
                    if (ct.Tag == null)
                        ct.Text = null;
                }
                else if (ct is RadioButton)
                    ((RadioButton)ct).Checked = false;
                else if (ct is DateTimePicker)
                    ((DateTimePicker)ct).CustomFormat = " ";
                else if (ct is PictureBox)
                    ((PictureBox)ct).Image = null;
            }
        }

        public static void KeyControl(Form frm, object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                frm.SelectNextControl((Control)sender, true, true, true, true);
            if (e.KeyCode == Keys.Up)
                frm.SelectNextControl((Control)sender, false, true, true, true);
        }

        public static void ConStrToTitle(TextBox txt)
        {
            TextInfo TI = new CultureInfo("en-US", false).TextInfo;
            txt.Text = TI.ToTitleCase(txt.Text);
        }

        public static void ConCurtoNumber(TextBox txt, object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text) || !string.IsNullOrWhiteSpace(txt.Text))
            {
                var s = decimal.Parse(txt.Text, NumberStyles.Currency);
                txt.Text = s.ToString();
            }
        }

        public static void InputCur(TextBox txt, object sender, KeyPressEventArgs e)
        {
            decimal x;
            char ch = e.KeyChar;
            if (ch == (char)8)//backspace
                e.Handled = false;
            else if (!char.IsDigit(ch) && ch != '.' || !decimal.TryParse(txt.Text + ch, out x))
                e.Handled = true;
        }

        public static void ConStringtoCur(TextBox txt, object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text) || !string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = string.Format("{0:C}", decimal.Parse(txt.Text));
            }
        }
    }
}