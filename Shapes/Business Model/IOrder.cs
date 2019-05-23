using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    public interface IOrder
    {
        int Number { get; set; }
        IPerson Customer { get; set; }
        IVehicle Vehicle { get; set; }
        IStore Store { get; set; }

        void Cancel();
    }
}
