using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class ObeyingClass : IWriter, ISleeper
    {
        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public void Write()
        {
            Console.WriteLine("Write");
        }
    }
}
