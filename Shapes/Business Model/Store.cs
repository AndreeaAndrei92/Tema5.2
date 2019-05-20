using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    class Store : IStore
    {
        public string Name { get; set; }
        public List<IOrder> Orders { get; set; } = new List<IOrder>();
        public List<IVehicle> Cars { get; set; }
    }
}
