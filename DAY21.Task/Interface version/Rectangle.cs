using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_version
{
    internal class Rectangle: IShape
    {
        public double Height;
        public double Width;

        public void CalculateArea()
        {
            Console.WriteLine(Height * Width);
        }
    }
}
