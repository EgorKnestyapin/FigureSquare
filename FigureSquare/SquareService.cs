using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    //Легкость добавления новых фигур
    internal class SquareService
    {
        public double GetSquare(Figure figure)
        {
            return figure.GetSquare();
        }
    }
}
