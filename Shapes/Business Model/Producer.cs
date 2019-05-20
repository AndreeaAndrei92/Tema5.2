using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    public abstract class Producer : IProducer
    {
        public string Manufacturer { get; set; }
    }
}

