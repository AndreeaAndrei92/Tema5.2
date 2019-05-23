using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    public interface IStore
    {
        string Name { get; set; }
        List<IOrder> Orders { get; set; }
        List<IVehicle> Cars { get; set; }
        void PlaceOrder(IVehicle vehicle, IPerson person);
        void CancelOrder(IOrder order, IPerson person);
    }
}

