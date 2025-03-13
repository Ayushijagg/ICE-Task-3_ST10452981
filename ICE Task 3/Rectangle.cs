using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3
{
    class Rectangle: Shape, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(string name,double length, double width):base(name)
        {   
            
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Length of Rectangle: {Length}\nWidth of rectangle: {Width}");
            Console.WriteLine($"Area Of Rectangle:{CalculateArea():F2}");
        }
    }
}
