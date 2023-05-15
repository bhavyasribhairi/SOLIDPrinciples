using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
     public class ObeyingBusinessLayer
    {
        private readonly IDataAccessLayer dataAccessLayer;

        public ObeyingBusinessLayer(IDataAccessLayer dataAccessLayer)
        {
            this.dataAccessLayer = dataAccessLayer;
        }

        public void Function1()
        {
            dataAccessLayer.GetOperation();
        }
    }
}
