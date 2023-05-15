using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class ViolatingClass : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
