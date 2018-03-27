using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SurfaceBlurTest
{

    public unsafe partial class FrmTest : Form
    { 

        [DllImport("SurfaceBlur.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern void SurfaceBlur(byte *Src, byte *Dest, int Width, int Height, int Stride, int Radius, int Threshold);

        Bitmap SrcBmp, DstBmp;
        int ImgWidth, ImgHeight, ImgStride;
        byte *Src, Dest;
        public FrmTest()
        {
            InitializeComponent();
        }
     

        private void CmdOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files(*.*) |*.*|Bitmap files (*.Bitmap)|*.Bmp|Jpeg files (*.jpg)|*.jpg|Png files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap Bmp = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                SrcBmp = (Bitmap)Bmp.Clone();
                DstBmp = (Bitmap)Bmp.Clone();
                Bmp.Dispose();
                PicSrc.Image = SrcBmp;
                PicDest.Image = DstBmp;
                CmdProcess_Click(sender, e);
            }
        }
            
        private void FrmTest_Load(object sender, EventArgs e)
        {
            SrcBmp = (Bitmap)PicSrc.Image;
            DstBmp = (Bitmap)PicDest.Image;
            CmdProcess_Click(sender, e);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap files (*.Bitmap)|*.Bmp|Jpeg files (*.jpg)|*.jpg|Png files (*.png)|*.png";
            saveFileDialog.FilterIndex = 3;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FilterIndex == 1)
                    DstBmp.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                else if (saveFileDialog.FilterIndex == 2)
                    DstBmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                else if (saveFileDialog.FilterIndex == 3)
                    DstBmp.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }
        private void CmdProcess_Click(object sender, EventArgs e)
        {
            
            if ((SrcBmp.PixelFormat == PixelFormat.Format8bppIndexed) || (SrcBmp.PixelFormat == PixelFormat.Format24bppRgb))
            {
                BitmapData SrcBmpData = SrcBmp.LockBits(new Rectangle(0, 0, SrcBmp.Width, SrcBmp.Height), ImageLockMode.ReadWrite, SrcBmp.PixelFormat);
                BitmapData DstBmpData = DstBmp.LockBits(new Rectangle(0, 0, DstBmp.Width, DstBmp.Height), ImageLockMode.ReadWrite, DstBmp.PixelFormat);

                ImgWidth = SrcBmp.Width;        ImgHeight = SrcBmp.Height;  ImgStride = SrcBmpData.Stride;
                Src = (byte*)SrcBmpData.Scan0;  Dest = (byte*)DstBmpData.Scan0;
                
                Stopwatch Sw = new Stopwatch();
                Sw.Start();
                SurfaceBlur(Src, Dest, ImgWidth, ImgHeight, ImgStride, Radius.Value, Threshold.Value);
                Sw.Stop();
                this.Text = "Processing Time " + Sw.ElapsedMilliseconds.ToString() + " ms";

                SrcBmp.UnlockBits(SrcBmpData);
                DstBmp.UnlockBits(DstBmpData);
                PicDest.Refresh();
            }
            else
            {
                MessageBox.Show("Not supported.");
            }
        }

        private void Radius_Scroll(object sender, ScrollEventArgs e)
        {
            LblRadius.Text = Radius.Value.ToString();
        }

        private void Threshold_Scroll(object sender, ScrollEventArgs e)
        {
            LblThreshold.Text = Threshold.Value.ToString();
        }


    }
}
