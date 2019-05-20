using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Model
{
    public class Car : Producer, IVehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }

        public Car(string manufacturer, string model, int year, float price)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Price = price;
        }

        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }
    }
}
