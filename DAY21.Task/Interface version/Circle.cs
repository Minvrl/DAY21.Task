using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_version
{
    internal class Circle: IShape
    {
        public double Radius;

        public void CalculateArea()
        {
            Console.WriteLine(Radius * Radius + "π");
        }

    }
}
