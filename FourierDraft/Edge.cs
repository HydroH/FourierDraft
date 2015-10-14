using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FourierDraft
{
    class Edge
    {
        //外部只读
        private List<List<BmpPoint>> edgeIndex;
        public List<List<BmpPoint>> EdgeIndex
        {
            get { return edgeIndex; }
        }

        //判定边缘点
        private bool IsWhite(ref Bitmap bmp, int x, int y)
        {
            if (x < 0 || x >= bmp.Width) return true;
            if (y < 0 || y >= bmp.Height) return true;
            if (bmp.GetPixel(x, y) == Color.White) return true;
            return false;
        }
        //查找边缘点
        private void FindNext(ref Bitmap bmp,ref int x,ref int y)
        {
            if (IsWhite(ref bmp, x, y - 1) && !IsWhite(ref bmp, x + 1, y - 1))
            {
                x += 1;
                y -= 1;
                return;
            }
            if (IsWhite(ref bmp, x + 1, y - 1) && !IsWhite(ref bmp, x + 1, y)) 
            {
                x += 1;
                return;
            }
            if (IsWhite(ref bmp, x + 1, y) && !IsWhite(ref bmp, x + 1, y + 1)) 
            {
                x += 1;
                y += 1;
                return;
            }
            if (IsWhite(ref bmp, x + 1, y + 1) && !IsWhite(ref bmp, x, y + 1)) 
            {
                y += 1;
                return;
            }
            if (IsWhite(ref bmp, x, y + 1) && !IsWhite(ref bmp, x - 1, y + 1))
            {
                x -= 1;
                y += 1;
                return;
            }
            if (IsWhite(ref bmp, x - 1, y + 1) && !IsWhite(ref bmp, x - 1, y)) 
            {
                x -= 1;
                return;
            }
            if (IsWhite(ref bmp, x - 1, y) && !IsWhite(ref bmp, x - 1, y - 1)) 
            {
                x -= 1;
                y -= 1;
                return;
            }
            if (IsWhite(ref bmp, x - 1, y - 1) && !IsWhite(ref bmp, x, y - 1)) 
            {
                y -= 1;
                return;
            }
        }
        //查找边缘
        public void FindEdge(Bitmap bmp)
        {
            edgeIndex = new List<List<BmpPoint>>();
            int bmpWidth = bmp.Width;
            int bmpHeight = bmp.Height;
            bool[,] visited = new bool[bmpWidth, bmpHeight];
            bool newEdge;
            for (int i = 0; i <= bmpWidth - 1; i++)
                for (int j = 0; j <= bmpHeight - 1; j++)
                {
                    newEdge = true;
                    int x = i;
                    int y = j;
                    while ((bmp.GetPixel(x, y) == Color.Black) && (!visited[x, y]))
                    {
                        if (newEdge) edgeIndex.Add(new List<BmpPoint>());
                        newEdge = false;
                        visited[x, y] = true;
                        edgeIndex[edgeIndex.Count].Add(new BmpPoint(x, y));
                        FindNext(ref bmp, ref x, ref y);
                    }
                }
        }
    }
}
