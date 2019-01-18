using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ImageDiffLahiru
{
    public partial class Form1 : Form
    {

        ScreenCapture sc = new ScreenCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void imgCapture_Click(object sender, EventArgs e)
        {
            Image img = sc.CaptureScreen();
            this.imageDisplay.Image = img;
            sc.CaptureWindowToFile(this.Handle, "D:\\temp.Jpeg", ImageFormat.Jpeg);
        }
    }
}
