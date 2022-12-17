using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    public class Triangle : Figure
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Одна из сторон меньше или равна нулю");
            this.a = a;
            this.b = b;
            this.c = c;
        }
  
        public double GetSquare()
        {
            double p = (a+b+c)/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
