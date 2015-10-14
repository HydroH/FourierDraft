using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourierDraft
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        BWImg img = new BWImg();
        Bitmap bmp;
        private void buttonImportPic_Click(object sender, EventArgs e)
        {
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                originPicBox.LoadAsync(openPic.FileName);
            }
        }
        private void originPicBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            img.ImgInit(originPicBox.Image, ref bmp);
            img.BWConvert(ref bmp, barThreshold.Value);
            bwPicBox.Image = bmp;
        }

        //滚动条与文本框结合
        private void barThreshold_Scroll(object sender, EventArgs e)
        {
            textThreshold.Text = Convert.ToString(barThreshold.Value);
        }
        private void textThreshold_TextChanged(object sender, EventArgs e)
        {
            try
            {
                barThreshold.Value = Convert.ToInt32(textThreshold.Text);
                img.BWConvert(ref bmp, barThreshold.Value);
                bwPicBox.Image = bmp;
            }
            catch { };
        }
    }
}
