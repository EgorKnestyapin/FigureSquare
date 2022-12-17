using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    public class Circle : Figure
    {
        public double rad;

        public Circle(double rad)
        {
            if (rad <= 0)
                throw new Exception("Радиус меньше или равен нулю");
            this.rad = rad;
        }
    
        public double GetSquare()
        {
            return Math.PI * rad * rad;
        }
    }
}
