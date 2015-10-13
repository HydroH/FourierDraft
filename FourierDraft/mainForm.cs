﻿using System;
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

        Image img = new Image();
        Bitmap originBmp = new Bitmap(500, 500);
        private void buttonImportPic_Click(object sender, EventArgs e)
        {
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                originPicBox.ImageLocation = openPic.FileName;
            }
            if (null != originPicBox.Image) originBmp = (Bitmap)originPicBox.Image;
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
            }
            catch { };
            originPicBox.Image = img.BWConvert(originBmp, barThreshold.Value);
        }
    }
}
