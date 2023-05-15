using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class AreaCalculator
    {
        public void CalculateTotalArea(Shape[] shapes)
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }

            Console.WriteLine("Area of shape is: " +totalArea);
        }
    }
}
