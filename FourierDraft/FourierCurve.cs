using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourierDraft
{
    class FourierCurve
    {
        struct Coefficient
        {
            public double sin, cos;
        }

        private Coefficient[] curveCoX, curveCoY;
        private int period;
        private string resultText;
        public string FourierExpand(List<BmpPoint> curvePoint, int expansionLevel)
        {
            curveCoX = new Coefficient[expansionLevel+1];
            curveCoY = new Coefficient[expansionLevel+1];
            period = curvePoint.Count;
            curveCoX[0].sin = curvePoint[0].y;
            curveCoY[0].sin = curvePoint[0].x;
            for (int i = 0; i <= period - 1; i++)
                for (int j = 1; j <= expansionLevel; j++)
                {
                    curveCoX[j].cos += curvePoint[i].x * Math.Cos(2 * Math.PI * (j + 1) * curvePoint[i].x / period);
                    curveCoX[j].sin += curvePoint[i].x * Math.Sin(2 * Math.PI * (j + 1) * curvePoint[i].x / period);
                    curveCoY[j].cos += curvePoint[i].y * Math.Cos(2 * Math.PI * (j + 1) * curvePoint[i].y / period);
                    curveCoY[j].sin += curvePoint[i].y * Math.Sin(2 * Math.PI * (j + 1) * curvePoint[i].y / period);
                }

            resultText = "x = ";
            resultText += Convert.ToString(curveCoX[0].sin);
            for (int i = 1; i <= expansionLevel; i++)
            {
                curveCoX[i].cos *= 2;
                curveCoX[i].sin *= 2;
                curveCoX[i].cos /= period;
                curveCoX[i].sin /= period;
                
                if (curveCoX[i].cos != 0)
                {
                    if (curveCoX[i].cos > 0) resultText += " +";
                    else resultText += " ";
                    resultText += Convert.ToString(Math.Round(curveCoX[i].cos, 4));
                    resultText += "cos(" + Convert.ToString(i) + "t)";
                }

                if (curveCoX[i].sin != 0)
                {
                    if (curveCoX[i].sin > 0) resultText += " +";
                    else resultText += " ";
                    resultText += Convert.ToString(Math.Round(curveCoX[i].sin, 4));
                    resultText += "sin(" + Convert.ToString(i) + "t)";
                }
                resultText += '\n';
            }

            resultText += "y = ";
            resultText += Convert.ToString(curveCoY[0].sin);
            for (int i = 1; i <= expansionLevel; i++) 
            {
                curveCoY[i].cos *= 2;
                curveCoY[i].sin *= 2;
                curveCoY[i].cos /= period;
                curveCoY[i].sin /= period;

                if (curveCoY[i].cos != 0)
                {
                    if (curveCoY[i].cos > 0) resultText += " +";
                    else resultText += " ";
                    resultText += Convert.ToString(Math.Round(curveCoY[i].cos, 4));
                    resultText += "cos(" + Convert.ToString(i) + "t)";
                }

                if (curveCoY[i].sin != 0)
                {
                    if (curveCoY[i].sin > 0) resultText += " +";
                    else resultText += " ";
                    resultText += Convert.ToString(Math.Round(curveCoY[i].sin, 4));
                    resultText += "sin(" + Convert.ToString(i) + "t)";
                }
                resultText += '\n';
            }
            return resultText;
        }
    }
}
