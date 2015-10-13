using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FourierDraft
{
    class Image
    {
        public Bitmap BWConvert(Bitmap img, int threshold)
        {
            for (int i = 0; i <= img.Width - 1; i++)
                for (int j = 0; j <= img.Height - 1; j++)
                {
                    Color color = img.GetPixel(i, j);
                    int grayness = color.R + color.B + color.G;
                    if (grayness > threshold * 3) img.SetPixel(i, j, Color.White);
                    else img.SetPixel(i, j, Color.Black);
                }
            return img;
        }
    }
}
