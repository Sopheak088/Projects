using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Notice.Gallery.View
{
    public partial class frmGallery : Form
    {
        string fp;
        List<byte[]> binpic = new List<byte[]>();
        List<MemoryStream> ms;
        public frmGallery()
        {
            InitializeComponent();
        }
        int i = 0;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private void frmGallery_Load(object sender, EventArgs e)
        {
            ShowPicture(0);
        }

        private int Total = 0;
        private void ShowPicture(int index = 0)
        {
            try
            {
                adapter = new SqlDataAdapter();
                dt = new DataTable();
                adapter.SelectCommand = new SqlCommand("SELECT (SELECT COUNT(ID) FROM GALLERY) AS Total, Photo AS Ph FROM GALLERY ORDER BY ID DESC OFFSET " + index+" ROW FETCH NEXT 1 ROWS ONLY", Connection.ToDatabase());
                adapter.Fill(dt);
                if (dt.Rows[0]["Total"].Equals(0) || string.IsNullOrWhiteSpace(dt.Rows[0]["Total"].ToString()))
                {
                    lblNum.Text = "0";
                    return;
                }

                Total = (int) dt.Rows[0]["Total"];
                lblNum.Text = 1 + "/" + dt.Rows[0]["Total"];
                Bitmap img;
                byte[] photo;
                photo = (byte[]) dt.Rows[0]["Ph"];

                if (photo.Equals(DBNull.Value)) return;
                MemoryStream ms = new MemoryStream(photo);
                img = new Bitmap(Image.FromStream(ms));
                picShow.Image = img;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            binpic = new List<byte[]>();
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All File | *.*| BMP FILE| *.bmp|JPEG FILE|.jgp; *.jpeg|PNG FILE| *.png";
            fd.Title = "Open an Image";
            fd.Multiselect = true;

            try
            {

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    fp = fd.FileName;
                    Image img;
                    foreach (string file in fd.FileNames)
                    {
                        img = Image.FromFile(file);
                        binpic.Add(GalleryEntity.ImgDao.ImageToByteArray(img));
                    }
                    for (int k = 0; k < binpic.Count; k++)
                    {
                        GalleryEntity.GalleryDao.Save(binpic[k], myClass.createDate, myClass.createBy);
                    }

                    ShowPicture(0);
                    i = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            i--;
            if (i < 0) { i = 0; return;}
            ShowPicture(i);
            lblNum.Text = i + 1 + "/" + Total;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= Total)
            {
                i = Total; return;}
            ShowPicture(i);
            lblNum.Text = i + 1 + "/" + Total;
        }

        private void savePic_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count < 0) return;
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = i+"";
            s.DefaultExt = ".jpg";
            s.Filter = "Image (.jpg)|*.jpg";
            string path;
            string fullPath = string.Empty;
            byte[] bitmap = (byte[])dt.Rows[0]["Ph"];
            string filename = string.Empty;
            bool ok=false;
            Image image = Image.FromStream(new MemoryStream(bitmap));
            if (s.ShowDialog() == DialogResult.OK)
            {
               filename = s.FileName;
                path = System.IO.Path.GetDirectoryName(s.FileName) + @"\";
                fullPath = filename;
                ok = true;
            }

            if (ok)
            {
                //MessageBox.Show(fullPath);
                FileStream fstream = new System.IO.FileStream(fullPath,FileMode.Create);
                image.Save(fstream,ImageFormat.Jpeg);  // Or Png
                fstream.Close();
            }
        }

        private void saveAllPic_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count < 0) return;
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = i + "";
            s.DefaultExt = ".jpg";
            s.Filter = "Image (.jpg)|*.jpg";
            string path=string.Empty;
            string fullPath = string.Empty;
            byte[] bitmap = null;
            string filename = string.Empty;
            bool ok = false;
            if (s.ShowDialog() == DialogResult.OK)
            {
                filename = Path.GetFileName(s.FileName);
                path = Path.GetDirectoryName(s.FileName) + @"\";
                ok = true;
            }

            if (ok)
            {
                Image image;
                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    bitmap = (byte[])dt.Rows[k]["Photo"];
                    image = Image.FromStream(new MemoryStream(bitmap));
                    FileStream fstream = new System.IO.FileStream(path + (int)(k+1) + " " + filename, FileMode.Create);
                    image.Save(fstream, ImageFormat.Jpeg);  // Or Png
                    fstream.Close();
                }
            }
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            Image img = picShow.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            picShow.Image = img;
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            Image img = picShow.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picShow.Image = img;
        }
    }
}
