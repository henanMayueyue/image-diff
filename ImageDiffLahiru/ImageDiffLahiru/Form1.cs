using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using WebPWrapper;

namespace ImageDiffLahiru
{
    public partial class Form1 : Form
    {

        ScreenCapture sc = new ScreenCapture();
        Image img;
        byte[] imageBytes;

        public Form1()
        {
            InitializeComponent();
        }

        private void imgCapture_Click(object sender, EventArgs e)
        {
            img = sc.CaptureScreen();
            this.imageDisplay.Image = img;
            sc.CaptureWindowToFile(this.Handle, "D:\\temp.Jpeg", ImageFormat.Jpeg);
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void saveWebp_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\temp.Jpeg");
            //using (WebP webp = new WebP())
                //webp.Save(bmp, 80, "test.webp");
            //int re = 75;

            byte[] rawWebP = File.ReadAllBytes("D:\\temp.Jpeg");
            using (WebP webp = new WebP())
                rawWebP = webp.EncodeLossy(bmp, 75);
            File.WriteAllBytes("D:\\WebPimage.webp", rawWebP);

            //imageBytes = ImageToByteArray(img);

        }

    }
}
