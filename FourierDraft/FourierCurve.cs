using System;
using System.Collections.Generic;

namespace FourierDraft
{
    struct Coefficient
    {
        public double sin, cos;
    }

    class FourierCurve
    {
        private Coefficient[] curveCoX, curveCoY;
        public Coefficient[] CurveCoX
        {
            get { return curveCoX; }
        }
        public Coefficient[] CurveCoY
        {
            get { return curveCoY; }
        }

        private int period;
        public int Period
        {
            get { return period; }
        }
        private string resultText;
        public string FourierExpand(List<BmpPoint> curvePoint, int expansionLevel)
        {
            period = curvePoint.Count;
            if (period <= 6) return "";
            curveCoX = new Coefficient[expansionLevel+1];
            curveCoY = new Coefficient[expansionLevel+1];
            curveCoX[0].sin = curvePoint[0].y;
            curveCoY[0].sin = curvePoint[0].x;
            double tempDouble;
            for (int i = 0; i <= period - 1; i++)
                for (int j = 1; j <= expansionLevel; j++)
                {
                    tempDouble = 2 * Math.PI * (j + 1) * curvePoint[i].x;
                    tempDouble /= period;
                    curveCoX[j].cos += curvePoint[i].x * Math.Cos(tempDouble);
                    curveCoX[j].sin += curvePoint[i].x * Math.Sin(tempDouble);
                    tempDouble = 2 * Math.PI * (j + 1) * curvePoint[i].y;
                    tempDouble /= period;
                    curveCoY[j].cos += curvePoint[i].y * Math.Cos(tempDouble);
                    curveCoY[j].sin += curvePoint[i].y * Math.Sin(tempDouble);
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
                resultText += "\r\n";
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
                resultText += "\r\n";
            }
            resultText += "\r\n";
            return resultText;
        }
    }
}
