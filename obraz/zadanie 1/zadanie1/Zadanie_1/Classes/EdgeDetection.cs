using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1.Classes
{
    public static class EdgeDetection
    {

        public static Complex[,] createEdgeDetectionFilter(Complex[,] fourierTAB, int rows, int cols,
                                                     double angleRadians, double cosPhiOffset, double minDistanceToCenter)
        {
            Complex[,] edgeDetectionFilterMask = new Complex[fourierTAB.GetLength(0), fourierTAB.GetLength(1)];

            for (int i = 0; i < fourierTAB.GetLength(0); i++)
            {
                for (int j = 0; j < fourierTAB.GetLength(1); j++)
                {
                    edgeDetectionFilterMask[i, j] = new Complex(0, 0);
                }
            }

            double rowsByTwo = rows / 2.0;
            double colsByTwo = cols / 2.0;
            Complex coefficient = fourierTAB[rows / 2, cols / 2];

            Vector2D right = new Vector2D(1, 0);
            right.rotate(angleRadians);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == rowsByTwo && j == colsByTwo)
                    {
                        continue;
                    }
                    if (j == colsByTwo)
                    {
                        float f = 5;
                    }

                    Vector2D vec = new Vector2D(j - colsByTwo, i - rowsByTwo);
                    Vector2D normalizedVec = vec.getNormalized();

                    bool validDirection = false;
                    double currentCosPhi = Vector2D.dot(normalizedVec, right);
                    if (currentCosPhi >= 0)
                    {
                        if (1.0 - currentCosPhi <= cosPhiOffset)  // both vectors point to the same direction
                        {
                            validDirection = true;
                        }
                    }
                    else
                    {
                        if (1.0 + currentCosPhi <= cosPhiOffset)  // currentVec points in the opposite direction
                        {
                            validDirection = true;
                        }
                    }

                    if (validDirection)
                    {
                        if (minDistanceToCenter < vec.length())
                        {
                            edgeDetectionFilterMask[i, j] = fourierTAB[i, j];
                        }
                    }
                }
            }

            edgeDetectionFilterMask[rows / 2,cols / 2] = coefficient;
            return edgeDetectionFilterMask;

        }


        struct Vector2D
        {
            double x;
            double y;

            public Vector2D(double v1, double v2)
            {
                this.x = v1;
                this.y = v2;
            }
            public void rotate(double angleRadians)
            {
                double tmpX = x * Math.Cos(angleRadians) - y * Math.Sin(angleRadians);
                y = x * Math.Sin(angleRadians) + y * Math.Cos(angleRadians);
                x = tmpX;
            }

            public Vector2D getNormalized()
            {
                // length must be greater than zero!
                double l = length();
                return new Vector2D(x / l, y / l);

            }


            public double length()
            {
                return Math.Sqrt(x * x + y * y);
            }
            public static double dot(Vector2D v1, Vector2D v2)
            {
                return v1.x * v2.x + v1.y * v2.y;
            }
        }
    }
}