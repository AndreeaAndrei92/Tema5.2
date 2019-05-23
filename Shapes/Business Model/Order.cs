using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    class Order : IOrder
    {
        public int Number { get; set; }
        public IStore Store { get; set; }
        public IPerson Customer { get; set; }
        public IVehicle Vehicle { get; set; }


        public Order(IPerson customer, IVehicle vehicle, IStore store)
        {
            Customer = customer;
            Vehicle = vehicle;
            Store = store;
        }
    }
}