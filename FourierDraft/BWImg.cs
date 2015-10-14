using System.Collections.Generic;
using System.Drawing;

namespace FourierDraft
{
    struct BmpPoint
    {
        public int x;
        public int y;
        public BmpPoint(int i, int j)
        {
            x = i;
            y = j;
        }
    }

    class BWImg
    {
        //图像初始化，建立灰度索引
        const int resizePixel = 500;
        private int imgWidth, imgHeight;
        private Bitmap originBmp;
        private List<BmpPoint>[] greynessIndex = new List<BmpPoint>[256];
        public void ImgInit(Image img, ref Bitmap bmp)
        {
            if (img.Width > resizePixel)
            {
                imgWidth = resizePixel;
                imgHeight = resizePixel * img.Height / img.Width;
            }
            if (imgHeight > resizePixel)
            {
                imgWidth = resizePixel * imgWidth / imgHeight;
                imgHeight = resizePixel;
            }
            bmp = new Bitmap(img, imgWidth, imgHeight);
            for (int i = 0; i <= 255; i++) greynessIndex[i] = new List<BmpPoint>();
            originBmp = new Bitmap(bmp);
            for (int i = 0; i <= imgWidth - 1; i++) 
                for (int j = 0; j <= imgHeight - 1; j++)
                {
                    Color currColor = bmp.GetPixel(i, j);
                    int greyness = (currColor.R + currColor.G + currColor.B) / 3;
                    BmpPoint currPoint = new BmpPoint(i,j);
                    greynessIndex[greyness].Add(currPoint);
                    bmp.SetPixel(i, j, Color.White);
                }
        }

        //图像二值化
        private int oldThresh = 0;
        public void BWConvert(ref Bitmap bmp, int threshold)
        {
            if (oldThresh < threshold)
                for (int k = oldThresh; k <= threshold - 1; k++)
                    for (int l = 0; l <= greynessIndex[k].Count - 1; l++)
                        bmp.SetPixel(greynessIndex[k][l].x, greynessIndex[k][l].y, Color.Black);
            else
                for (int k = threshold; k <= oldThresh - 1; k++)
                    for (int l = 0; l <= greynessIndex[k].Count - 1; l++)
                        bmp.SetPixel(greynessIndex[k][l].x, greynessIndex[k][l].y, Color.White);
            oldThresh = threshold;
        }
    }
}
