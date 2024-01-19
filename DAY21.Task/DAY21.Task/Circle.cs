using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY21.Task
{
    internal class Circle:Shape
    {
        public double Radius;

        public override void CalculateArea()
        {
            Console.WriteLine(Radius*Radius+"π"); 
        }
    }
}
