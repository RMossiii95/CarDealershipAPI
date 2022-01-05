using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipAPI
{
    public class Inventory
    {
        public List<Car> ListOfCars { get; set; } = new List<Car>();
        public Inventory()
        {
            ListOfCars.Add(new Car("Ford", "Bronco", 2021, "White"));
            ListOfCars.Add(new Car("Ford", "F-150", 2020, "Black"));
            ListOfCars.Add(new Car("Chevy", "Cruze", 2009, "Tan"));
            ListOfCars.Add(new Car("Toyota", "Camry", 2005, "Gray"));
            ListOfCars.Add(new Car("GMC", "Sierra", 2010, "Red"));
            ListOfCars.Add(new Car("Nissan", "Ultima", 2007, "Yellow"));
            ListOfCars.Add(new Car("Ford", "Fusion", 2020, "Black"));
            ListOfCars.Add(new Car("Toyota", "Corolla", 2012, "White"));
            ListOfCars.Add(new Car("Tesla", "Model S", 2018, "Red"));

        }
    }
}
