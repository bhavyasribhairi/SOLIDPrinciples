using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class DataAccessLayer :IDataAccessLayer
    {

        public void GetOperation()
        {
            Console.WriteLine("Operation done..");
        }
    }
}
