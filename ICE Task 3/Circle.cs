using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3
{
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }

        public Circle(string name,double radius ) : base(name)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return (Radius * Radius) * Math.PI;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius of circle:{Radius}");
            Console.WriteLine($"Area Of Circle:{CalculateArea():F2}");
        }
    }
}
