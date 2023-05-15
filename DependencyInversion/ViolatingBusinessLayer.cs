using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class ViolatingBusinessLayer
    {
        private readonly DataAccessLayer dataAccessLayer;

        public ViolatingBusinessLayer(DataAccessLayer dataAccessLayer)
        {
            this.dataAccessLayer = dataAccessLayer;
        }

        public void Function1()
        {
            dataAccessLayer.GetOperation();
        }


    }
}
