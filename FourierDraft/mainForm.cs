using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FourierDraft
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //图片载入
        CurveImg img = new CurveImg();
        Bitmap bwBmp, edgeBmp;
        private void buttonImportPic_Click(object sender, EventArgs e)
        {
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                originPicBox.LoadAsync(openPic.FileName);
            }
        }
        private void originPicBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            img.ImgInit(originPicBox.Image, ref bwBmp);
            img.BWConvert(ref bwBmp, barThreshold.Value);
            bwPicBox.Image = bwBmp;
            edgeBmp = new Bitmap(bwBmp);
            img.PreviewEdge(ref edgeBmp);
            edgePicBox.Image = edgeBmp;
        }

        //滚动条与文本框结合
        private void barThreshold_Scroll(object sender, EventArgs e)
        {
            textThreshold.Text = Convert.ToString(barThreshold.Value);
        }

        private void tabEdge_Enter(object sender, EventArgs e)
        {
            edgeBmp = new Bitmap(bwBmp);
            img.PreviewEdge(ref edgeBmp);
            edgePicBox.Image = edgeBmp;
        }

        private void textThreshold_TextChanged(object sender, EventArgs e)
        {
            try
            {
                barThreshold.Value = Convert.ToInt32(textThreshold.Text);
            }
            catch { };
            img.BWConvert(ref bwBmp, barThreshold.Value);
            bwPicBox.Image = bwBmp;
            edgeBmp = new Bitmap(bwBmp);
            img.PreviewEdge(ref edgeBmp);
            edgePicBox.Image = edgeBmp;
        }
    }
}
