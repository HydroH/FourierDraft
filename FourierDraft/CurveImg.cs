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
            for (int i = 0; i <= edgePointIndex[threshold].Count - 1; i++)
                bmp.SetPixel(edgePointIndex[threshold][i].x, edgePointIndex[threshold][i].y, Color.Black);
        }

        //相邻点遍历
        private BmpPoint GetPoint(BmpPoint point,int i)
        {
            switch (i)
            {
                case 0: return new BmpPoint(point.x - 1, point.y - 1);
                case 1: return new BmpPoint(point.x    , point.y - 1);
                case 2: return new BmpPoint(point.x + 1, point.y - 1);
                case 3: return new BmpPoint(point.x + 1, point.y    );
                case 4: return new BmpPoint(point.x + 1, point.y + 1);
                case 5: return new BmpPoint(point.x    , point.y + 1);
                case 6: return new BmpPoint(point.x - 1, point.y + 1);
                case 7: return new BmpPoint(point.x - 1, point.y    );
                default:return point;
            }
        }

        //判定边缘点
        private bool IsWhite(int x, int y)
        {
            if (x < 0 || x >= bmpWidth) return true;
            if (y < 0 || y >= bmpHeight) return true;
            if (!isBlack[x, y]) return true;
            return false;
        }

        //查找边缘点
        private void FindNext(ref int x, ref int y, ref int position, bool[,] isEdge)
        {
            BmpPoint newPoint;
            for (int i = position + 1; i <= position + 8; i++) 
            {
                newPoint = GetPoint(new BmpPoint(x, y), i % 8);
                if ((newPoint.x < 0) || (newPoint.x >= bmpWidth) || (newPoint.y < 0) || (newPoint.y >= bmpHeight)) continue;
                if (isEdge[newPoint.x,newPoint.y])
                {
                    x = newPoint.x;
                    y = newPoint.y;
                    position = (i + 4) % 8;
                    return;
                }
            }
        }

        private void FindSingleEdge(int x, int y, ref bool[,] visited, bool[,] isEdge)
        {
            int x0 = x;
            int y0 = y;
            int position = 0;
            FindNext(ref x, ref y, ref position, isEdge);
            edgeIndex[edgeIndex.Count - 1].Add(new BmpPoint(x, y));
            while ((x != x0) || (y != y0))
            {
                FindNext(ref x, ref y, ref position, isEdge);
                edgeIndex[edgeIndex.Count - 1].Add(new BmpPoint(x, y));
                visited[x, y] = true;
            }
        }

        public void FindEdge(int threshold)
        {
            int x, y;
            bool[,] visited = new bool[bmpWidth, bmpHeight];
            bool[,] isEdge = new bool[bmpWidth, bmpHeight];
            edgeIndex = new List<List<BmpPoint>>();
            for (int i = 0; i <= edgePointIndex[threshold].Count - 1; i++)
                isEdge[edgePointIndex[threshold][i].x, edgePointIndex[threshold][i].y] = true;
            for (int i = 0; i <= edgePointIndex[threshold].Count - 1; i++)
            {
                x = edgePointIndex[threshold][i].x;
                y = edgePointIndex[threshold][i].y;
                if (!visited[x, y])
                {
                    edgeIndex.Add(new List<BmpPoint>());
                    FindSingleEdge(x, y, ref visited, isEdge);
                }
            }
        }

        //绘制部分
        //清空画布
        public void ClearCanvas(ref Bitmap bmp)
        {
            bmp = new Bitmap(whiteBmp);
        }
        //绘制曲线
        public void DrawCurve(Coefficient[] curveCoX, Coefficient[] curveCoY, int period, ref Bitmap bmp, int accuracy)
        {
            double x, y;
            int intx, inty;
            double tempDouble;
            for (int i = 0; i <= period * accuracy - 1; i++) 
            {
                if (null == curveCoX) continue;
                x = curveCoX[0].cos / 2;
                y = curveCoY[0].cos / 2;
                for (int j = 1; j <= curveCoX.Length - 1; j++) 
                {
                    tempDouble = 2 * Math.PI * j * i / accuracy;
                    tempDouble /= period;
                    x += curveCoX[j].cos * Math.Cos(tempDouble);
                    x += curveCoX[j].sin * Math.Sin(tempDouble);
                    tempDouble = 2 * Math.PI * j * i / accuracy;
                    tempDouble /= period;
                    y += curveCoY[j].cos * Math.Cos(tempDouble);
                    y += curveCoY[j].sin * Math.Sin(tempDouble);
                }
                intx = (int)Math.Round(x);
                inty = (int)Math.Round(y);
                if ((intx < 0) || (intx >= bmp.Width) || (inty < 0) || (inty >= bmp.Height)) continue;
                bmp.SetPixel(intx, inty, Color.Black);
            }
        }
    }
}
