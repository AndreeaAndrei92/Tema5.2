using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    class Customer : IPerson
    {
  
      public Customer(string name)
            {
                Name = name;
            }
        public string Name { get; set; }
        public List<IOrder> Orders { get; set; } = new List<IOrder>();

        public void PlaceOrder(IStore store, IVehicle vehicle)
        {
            store.PlaceOrder(vehicle, this);
        }

        public void CancelOrder(IStore store, IOrder order)
        {
            if (Orders.Exists(o => o.Store == order.Store && o.Number == order.Number))
            {
                store.CancelOrder(order, this);
            }
        }

    }
}
