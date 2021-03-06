﻿using System;
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
        public string FourierExpand(List<BmpPoint> curvePoint, int expansionLevel, int ignoreThres)
        {
            period = curvePoint.Count;
            if (period <= ignoreThres) return "";
            curveCoX = new Coefficient[expansionLevel+1];
            curveCoY = new Coefficient[expansionLevel+1];
            double tempDouble;
            for (int i = 0; i <= expansionLevel; i++)
                for (int j = 0; j <= period - 1; j++) 
                {
                    tempDouble = 2 * Math.PI * i * j;
                    tempDouble /= period;
                    curveCoX[i].cos += curvePoint[j].x * Math.Cos(tempDouble);
                    curveCoX[i].sin += curvePoint[j].x * Math.Sin(tempDouble);
                    tempDouble = 2 * Math.PI * i * j;
                    tempDouble /= period;
                    curveCoY[i].cos += curvePoint[j].y * Math.Cos(tempDouble);
                    curveCoY[i].sin += curvePoint[j].y * Math.Sin(tempDouble);
                }
            curveCoX[0].cos *= 2;
            curveCoX[0].cos /= period;
            curveCoY[0].cos *= 2;
            curveCoY[0].cos /= period;
            resultText = "x = ";
            resultText += Convert.ToString(Math.Round(curveCoX[0].cos, 4));
            for (int i = 1; i <= expansionLevel; i++)
            {
                curveCoX[i].cos *= 2;
                curveCoX[i].sin *= 2;
                curveCoX[i].cos /= period;
                curveCoX[i].sin /= period;

                if (Math.Round(curveCoX[i].cos, 4) >= 0) resultText += " +";
                else resultText += " ";
                resultText += Convert.ToString(Math.Round(curveCoX[i].cos, 4));
                resultText += "cos(" + Convert.ToString(i) + "t)";

                if (Math.Round(curveCoX[i].sin, 4) >= 0) resultText += " +";
                else resultText += " ";
                resultText += Convert.ToString(Math.Round(curveCoX[i].sin, 4));
                resultText += "sin(" + Convert.ToString(i) + "t)";
            
                resultText += "\r\n";
            }
            
            resultText += "y = ";
            resultText += Convert.ToString(Math.Round(curveCoY[0].cos, 4));
            for (int i = 1; i <= expansionLevel; i++)
            {
                curveCoY[i].cos *= 2;
                curveCoY[i].sin *= 2;
                curveCoY[i].cos /= period;
                curveCoY[i].sin /= period;

                if (Math.Round(curveCoY[i].cos, 4) >= 0) resultText += " +";
                else resultText += " ";
                resultText += Convert.ToString(Math.Round(curveCoY[i].cos, 4));
                resultText += "cos(" + Convert.ToString(i) + "t)";

                if (Math.Round(curveCoY[i].sin, 4) >= 0) resultText += " +";
                else resultText += " ";
                resultText += Convert.ToString(Math.Round(curveCoY[i].sin, 4));
                resultText += "sin(" + Convert.ToString(i) + "t)";
            
                resultText += "\r\n";
            }
            resultText += "\r\n";
            return resultText;
        }
    }
}
