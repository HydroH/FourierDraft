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
        Bitmap bwBmp, edgeBmp, curveBmp;
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
            img.PreviewEdge(ref edgeBmp, barThreshold.Value);
            edgePicBox.Image = edgeBmp;
        }

        //保存曲线图片
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (null == curvePicBox.Image) return;
            saveCurve.FileName = "Curve Image.png";
            if (saveCurve.ShowDialog() == DialogResult.OK)
            {
                curvePicBox.Image.Save(saveCurve.FileName);
            }
        }

        //图片框显示
        bool bwShowing = false;
        bool edgeShowing = false;

        private void tabOrigin_Enter(object sender, EventArgs e)
        {
            bwShowing = false;
            edgeShowing = false;
        }

        private void tabBW_Enter(object sender, EventArgs e)
        {
            img.BWConvert(ref bwBmp, barThreshold.Value);
            bwPicBox.Image = bwBmp;
            bwShowing = true;
            edgeShowing = false;
        }

        private void tabEdge_Enter(object sender, EventArgs e)
        {
            img.PreviewEdge(ref edgeBmp, barThreshold.Value);
            edgePicBox.Image = edgeBmp;
            bwShowing = false;
            edgeShowing = true;
        }

        private void tabCurve_Enter(object sender, EventArgs e)
        {
            bwShowing = false;
            edgeShowing = false;
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
            if (bwShowing)
            {
                img.BWConvert(ref bwBmp, barThreshold.Value);
                bwPicBox.Image = bwBmp;
            }
            if (edgeShowing)
            {
                img.PreviewEdge(ref edgeBmp, barThreshold.Value);
                edgePicBox.Image = edgeBmp;
            }
        }

        private void barLevel_Scroll(object sender, EventArgs e)
        {
            textLevel.Text = Convert.ToString(barLevel.Value);
        }

        private void textLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                barLevel.Value = Convert.ToInt32(textLevel.Text);
            }
            catch { };
        }

        bool start;
        private void buttonAbort_Click(object sender, EventArgs e)
        {
            start = false;
        }

        //傅里叶展开
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (null != originPicBox.Image)
            {
                start = true;
                img.BWConvert(ref bwBmp, barThreshold.Value);
                edgeBmp = new Bitmap(bwBmp);
                img.FindEdge(barThreshold.Value);
                textResult.Text = "";
                FourierCurve[] curves = new FourierCurve[img.EdgeIndex.Count];
                progressBar.Value = 0;
                progressBar.Maximum = img.EdgeIndex.Count;
                buttonCalc.Enabled = false;
                for (int i = 0; i <= img.EdgeIndex.Count - 1; i++)
                {
                    if (!start)
                    {
                        progressBar.Value = 0;
                        start = true;
                        buttonCalc.Enabled = true;
                        return;
                    }
                    curves[i] = new FourierCurve();
                    textResult.Text += curves[i].FourierExpand(img.EdgeIndex[i], Math.Min(barLevel.Value, img.EdgeIndex[i].Count / 2), (int)numIgnore.Value);
                    Application.DoEvents();
                    progressBar.PerformStep();
                }
                img.ClearCanvas(ref curveBmp);
                for (int i = 0; i <= img.EdgeIndex.Count - 1; i++)
                {
                    img.DrawCurve(curves[i].CurveCoX, curves[i].CurveCoY, curves[i].Period, ref curveBmp, (int)numAccuracy.Value);
                    Application.DoEvents();
                }
                curvePicBox.Image = curveBmp;
                progressBar.Value = 0;
                buttonCalc.Enabled = true;
            }
        }
    }
}
