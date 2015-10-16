using System;
using System.Collections.Generic;
using System.Drawing;

namespace FourierDraft
{
    struct BmpPoint
    {
        public int x, y;
        public BmpPoint(int i, int j)
        {
            x = i;
            y = j;
        }
    }

    class CurveImg
    {
        //图像初始化，建立灰度索引&边缘点索引
        const int resizePixel = 450; //放肆！
        private int bmpWidth, bmpHeight;
        private Bitmap originBmp, whiteBmp;
        private bool[,] isBlack;
        private List<BmpPoint>[] greynessIndex = new List<BmpPoint>[256];
        private List<BmpPoint>[] edgePointIndex = new List<BmpPoint>[256];
        public void ImgInit(Image img, ref Bitmap bmp)
        {
            bmpWidth = img.Width;
            bmpHeight = img.Height;

            bmpHeight = resizePixel * bmpHeight / bmpWidth;
            bmpWidth = resizePixel;

            if (bmpHeight > resizePixel)
            {
                bmpWidth = resizePixel * bmpWidth / bmpHeight;
                bmpHeight = resizePixel;
            }

            isBlack = new bool[bmpWidth, bmpHeight];
            bmp = new Bitmap(img, bmpWidth, bmpHeight);
            for (int i = 0; i <= 255; i++)
            {
                greynessIndex[i] = new List<BmpPoint>();
                edgePointIndex[i] = new List<BmpPoint>();
            }
            originBmp = new Bitmap(bmp);
            for (int i = 0; i <= bmpWidth - 1; i++) 
                for (int j = 0; j <= bmpHeight - 1; j++)
                {
                    //灰度索引初始化
                    Color currColor = bmp.GetPixel(i, j);
                    int greyness = currColor.R + currColor.G + currColor.B;
                    BmpPoint currPoint = new BmpPoint(i,j);
                    greynessIndex[greyness / 3].Add(currPoint);
                    bmp.SetPixel(i, j, Color.White);
                    //边缘索引初始化
                    if (i == 0 || i == bmpWidth - 1 || j == 0 || j == bmpHeight - 1)
                    {
                        for (int k = greyness / 3; k <= 255; k++) edgePointIndex[k].Add(currPoint);
                        continue;
                    }
                    int newGreyness;
                    currColor = originBmp.GetPixel(i - 1, j);
                    newGreyness = currColor.R + currColor.G + currColor.B;
                    currColor = originBmp.GetPixel(i + 1, j);
                    newGreyness = Math.Max(newGreyness, currColor.R + currColor.G + currColor.B);
                    currColor = originBmp.GetPixel(i, j - 1);
                    newGreyness = Math.Max(newGreyness, currColor.R + currColor.G + currColor.B);
                    currColor = originBmp.GetPixel(i, j + 1);
                    newGreyness = Math.Max(newGreyness, currColor.R + currColor.G + currColor.B);
                    for (int k = greyness / 3 + 1; k <= newGreyness / 3; k++) edgePointIndex[k].Add(currPoint);
                }
            oldThresh = 0;
            whiteBmp = new Bitmap(bmp);
        }

        //图像二值化
        private int oldThresh = 0;
        public void BWConvert(ref Bitmap bmp, int threshold)
        {
            if (oldThresh < threshold)
                for (int k = oldThresh; k <= threshold - 1; k++)
                    for (int l = 0; l <= greynessIndex[k].Count - 1; l++)
                    {
                        bmp.SetPixel(greynessIndex[k][l].x, greynessIndex[k][l].y, Color.Black);
                        isBlack[greynessIndex[k][l].x, greynessIndex[k][l].y] = true;
                    }
                        
            else
                for (int k = threshold; k <= oldThresh - 1; k++)
                    for (int l = 0; l <= greynessIndex[k].Count - 1; l++)
                    {
                        bmp.SetPixel(greynessIndex[k][l].x, greynessIndex[k][l].y, Color.White);
                        isBlack[greynessIndex[k][l].x, greynessIndex[k][l].y] = false;
                    }
            oldThresh = threshold;
        }

        //查找边缘部分
        //外部只读
        private List<List<BmpPoint>> edgeIndex;
        public List<List<BmpPoint>> EdgeIndex
        {
            get { return edgeIndex; }
        }

        //预览边缘
        public void PreviewEdge(ref Bitmap bmp, int threshold)
        {
            bmp = new Bitmap(whiteBmp);
            for (int j = 0; j <= edgePointIndex[threshold].Count - 1; j++)
                bmp.SetPixel(edgePointIndex[threshold][j].x, edgePointIndex[threshold][j].y, Color.Black);
        }

        //判定边缘点
        private bool IsWhite(ref Bitmap bmp, int x, int y)
        {
            if (x < 0 || x >= bmp.Width) return true;
            if (y < 0 || y >= bmp.Height) return true;
            if (!isBlack[x, y]) return true;
            return false;
        }

        //查找边缘点
        private void FindNext(ref Bitmap bmp, ref int x, ref int y, bool[,] visited)
        {
            if (IsWhite(ref bmp, x, y - 1) && !IsWhite(ref bmp, x + 1, y - 1) && !visited[x + 1, y - 1]) 
            {
                x += 1;
                y -= 1;
                return;
            }
            if (IsWhite(ref bmp, x + 1, y - 1) && !IsWhite(ref bmp, x + 1, y) && !visited[x + 1, y])
            {
                x += 1;
                return;
            }
            if (IsWhite(ref bmp, x + 1, y) && !IsWhite(ref bmp, x + 1, y + 1) && !visited[x + 1, y + 1])
            {
                x += 1;
                y += 1;
                return;
            }
            if (IsWhite(ref bmp, x + 1, y + 1) && !IsWhite(ref bmp, x, y + 1) && !visited[x, y + 1])
            {
                y += 1;
                return;
            }
            if (IsWhite(ref bmp, x, y + 1) && !IsWhite(ref bmp, x - 1, y + 1) && !visited[x - 1, y + 1])
            {
                x -= 1;
                y += 1;
                return;
            }
            if (IsWhite(ref bmp, x - 1, y + 1) && !IsWhite(ref bmp, x - 1, y) && !visited[x - 1, y])
            {
                x -= 1;
                return;
            }
            if (IsWhite(ref bmp, x - 1, y) && !IsWhite(ref bmp, x - 1, y - 1) && !visited[x - 1, y - 1])
            {
                x -= 1;
                y -= 1;
                return;
            }
            if (IsWhite(ref bmp, x - 1, y - 1) && !IsWhite(ref bmp, x, y - 1) && !visited[x, y - 1])
            {
                y -= 1;
                return;
            }
        }

        //查找单条边缘
        private void FindSingleEdge(ref Bitmap bmp, int x, int y, ref bool[,] visited)
        {
            bool newEdge = true;
            int x0 = x;
            int y0 = y;
            FindNext(ref bmp, ref x, ref y, visited);
            if ((x0 == x) && (y0 == y)) return;
            x = x0;
            y = y0;
            while ((isBlack[x, y]) && (!visited[x, y])) 
            {
                if (newEdge) edgeIndex.Add(new List<BmpPoint>());
                newEdge = false;
                visited[x, y] = true;
                edgeIndex[edgeIndex.Count - 1].Add(new BmpPoint(x, y));
                FindNext(ref bmp, ref x, ref y, visited);
                if ((x0 == x) && (y0 == y)) break;
                x0 = x;
                y0 = y;
            }
        }

        //查找边缘
        public void FindEdge(ref Bitmap bmp)
        {
            edgeIndex = new List<List<BmpPoint>>();
            int bmpWidth = bmp.Width;
            int bmpHeight = bmp.Height;
            bool[,] visited = new bool[bmpWidth, bmpHeight];

            for (int i = 0; i <= oldThresh - 1; i++)
                for (int j = 0; j <= greynessIndex[i].Count - 1; j++)
                    FindSingleEdge(ref bmp, greynessIndex[i][j].x, greynessIndex[i][j].y, ref visited);

            for (int i = 0; i <= bmpWidth - 1; i++)
                for (int j = 0; j <= bmpHeight - 1; j++)
                    bmp.SetPixel(i, j, Color.White);

            for (int i = 0; i <= edgeIndex.Count - 1; i++)
                for (int j = 0; j <= edgeIndex[i].Count - 1; j++)
                    bmp.SetPixel(edgeIndex[i][j].x, edgeIndex[i][j].y, Color.Black);
        }

        //绘制部分
        //清空画布
        public void ClearCanvas(ref Bitmap bmp)
        {
            bmp = new Bitmap(whiteBmp);
        }
        //绘制曲线
        public void DrawCurve(Coefficient[] curveCoX, Coefficient[] curveCoY, int period, ref Bitmap bmp)
        {
            double x;
            double y;
            double tempDouble;
            for (int i = 0; i <= period - 1; i++)
            { 
                x = 0;
                y = 0;
                for (int j = 0; j <= curveCoX.Length - 1; j++) 
                {
                    tempDouble = 2 * Math.PI * j * x;
                    tempDouble /= period;
                    x += curveCoX[j].cos * Math.Cos(tempDouble);
                    x += curveCoX[j].sin * Math.Sin(tempDouble);
                    tempDouble = 2 * Math.PI * j * y;
                    tempDouble /= period;
                    y += curveCoY[j].cos * Math.Cos(tempDouble);
                    y += curveCoY[j].sin * Math.Sin(tempDouble);
                }
                x = -x;
                y = -y;
                if ((x < 0) || (x >= bmp.Width) || (y < 0) || (y >= bmp.Height)) continue;
                bmp.SetPixel((int)x, (int)y, Color.Black);
            }
        }
    }
}
