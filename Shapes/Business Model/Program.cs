using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson Alex = new Customer("Alex");
            IVehicle FordFocus = new Car("Ford", "Focus", 2015);
            IStore FordStore = new Store("Ford Store", 4,
            new List<IVehicle>() {
                    new Car("Ford", "Focus", 2015, 15000),
            });

            Operation.PlaceOrder(Alex, FordStore, FordFocus);
            Operation.PrintOrders(Alex, "Orders after ordering from Ford Store");
            Operation.PlaceOrder(Alex, FordStore, FordFocus);
            Operation.PrintOrders(Alex, "Orders after ordering new model from Skoda Store");
            Operation.CancelOrder(Alex, FordStore, FordFocus);
            Operation.PrintOrders(Alex, "Orders after cancelling the order on Ford Store");
            Console.ReadKey();
        }
    }
}
