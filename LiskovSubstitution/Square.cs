using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Square :Shape
    {
        public double Side { get; set; }

        public override double CalculateArea()
        {
            return Side * Side;
        }


    }
}
