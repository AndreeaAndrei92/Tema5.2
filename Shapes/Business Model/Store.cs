using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    public class Store : IStore
    {
        public string Name { get; set; }
        public List<IOrder> Orders { get; set; } = new List<IOrder>();
        public List<IVehicle> Cars { get; set; }

        int lastOrderID = 0;

        public Store(string name, List<IVehicle> cars)
        {
            Name = name;
            Cars = cars;
            public void PlaceOrder(IVehicle vehicle, IPerson customer)
            {
                if (Cars.Exists(c => c.Manufacturer == vehicle.Manufacturer && c.Model == vehicle.Model))
                {
                    IOrder order = new Order(customer, vehicle, this);
                    order.Number = ++lastOrderID;
                    order.Vehicle = Cars.Find(c => c.Manufacturer == vehicle.Manufacturer && c.Model == vehicle.Model);
                    Orders.Add(order);
                    customer.Orders.Add(order);
                }
            }

            public void CancelOrder(IOrder order, IPerson customer)
            {
                if (Orders.Exists(o => o.Number == order.Number))
                {
                    Orders.Remove(Orders.Find(o => o.Number == order.Number));
                    customer.Orders.Remove(customer.Orders.Find(o => o.Store == order.Store && o.Number == order.Number));
                }
            }
        }
    }
}

