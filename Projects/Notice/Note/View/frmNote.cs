using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pheak.GridEx;

namespace Notice.Note.View
{
    public partial class frmLoveCount : Form
    {
        private int? id;
        public frmLoveCount()
        {
            InitializeComponent();
            gridNote.RootTable.Columns["NoteDate"].FormatString = String.Format("dd/MMMM/yyyy");
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            refresh();
            visible(true);
        }

        private void refresh()
        {
            id = null;
            pGridEX.BindDataIntoGrid(Connection.ToDatabase(), "ListAllNote", gridNote);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (gridNote.Visible)Close();
            else visible(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                return;
            }
            DateTime noteDate = DateTime.Parse(dtpNote.Value.ToString("dd/MMMM/yyyy"));
            string note = txtNote.Text;
            if (id.Equals(null))
            {
                NoteDao.SaveNote(note, noteDate, myClass.createDate, myClass.createBy);
            }
            else
            {
                NoteDao.SaveNote(note, noteDate, myClass.createDate, myClass.createBy,id);
            }
            
            Refresh();
            visible(true);
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            id = null;
            visible(false);
            txtNote.Text = string.Empty;
            dtpNote.Value = DateTime.Today;
            txtNote.Focus();
        }

        void visible(bool isNew)
        {
            btnNew.Visible = isNew;
            gridNote.Visible = isNew;
            lblNoteDate.Visible = !isNew;
            txtNote.Visible = !isNew;
            btnSave.Visible = !isNew;
            dtpNote.Visible = !isNew;
        }

        private void gridNote_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                SqlDataAdapter adapter;
                DataTable dt;
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand =
                    new SqlCommand("SELECT * FROM NOTE WHERE ID=" + gridNote.GetRow().Cells["ID"].Value,
                        Connection.ToDatabase());
                adapter.Fill(dt);
                id = int.Parse(dt.Rows[0]["ID"].ToString());

                txtNote.Text = dt.Rows[0]["Note"].ToString();
                visible(false);
                DateTime dtp = (DateTime) dt.Rows[0]["NoteDate"];
                dtpNote.Format = DateTimePickerFormat.Custom;
                dtpNote.CustomFormat = "dd/MM/yyyy";
                dtpNote.Value = dtp;
            }
            catch (Exception exception)
            {
                return;
            }
        }
    }
}
