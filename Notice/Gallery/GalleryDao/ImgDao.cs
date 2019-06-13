using System.Drawing;

namespace Notice.Gallery.GalleryEntity
{
    class ImgDao
    {
        public static byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
