using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    //Проверка на то, является ли треугольник прямоугольным 
    internal class TriangleService
    {
        public bool isRectangular(Figure figure)
        {
            Triangle triangle = (Triangle)figure;
            double aPow = Math.Pow(triangle.a, 2);
            double bPow = Math.Pow(triangle.b, 2);
            double cPow = Math.Pow(triangle.c, 2);
            return cPow == aPow + bPow && bPow == aPow + cPow && aPow == cPow + bPow;
        }
    }
}
