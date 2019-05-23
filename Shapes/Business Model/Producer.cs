using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    public abstract class Producer : IProducer
    { 
        public Producer(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
}

