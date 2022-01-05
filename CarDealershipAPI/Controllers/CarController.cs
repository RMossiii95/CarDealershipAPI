using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        Inventory lot1 = new Inventory();

        [HttpGet]
        public List<Car> ListAllCars()
        {
            return lot1.ListOfCars;
        }
        [HttpGet("GetAllMakes/{make}")]
        public List<Car> GetAllMakes(string make)
        {
            List<Car> cars = new List<Car>();
            foreach(Car c in lot1.ListOfCars)
            {
                if(c.Make.Contains(make) || c.Make.ToLower() == make.ToLower())
                {
                    cars.Add(c);
                }
            }
            return cars;
        }
        [HttpGet("GetAllColors/{color}")]
        public List<Car> GetCarColor(string color)
        {
            List<Car> cars = new List<Car>();
            foreach(Car c in lot1.ListOfCars)
            {
                if(c.Color.Contains(color) || c.Color.ToLower() == color.ToLower())
                {
                    cars.Add(c);
                }
            }
            return cars;
        }
        [HttpGet("IndexOfCars/{index}")]
        public string IndexOfCars(int index)
        {
            return lot1.ListOfCars[index].ToString();
        }
    }
}
