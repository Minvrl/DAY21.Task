using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY21.Task
{
    internal class Rectangle:Shape
    {
        public double Height;
        public double Width;

        public override void CalculateArea()
        {
            Console.WriteLine(Height*Width);
        }

    }
}
