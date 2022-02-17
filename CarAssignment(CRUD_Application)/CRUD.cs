using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    interface CRUD
    {
        ICollection<Car> GetCars();
        void AddCar(Car obj);
        void DeleteCar(Car obj);
        Car Findcar(string vin);
        void UpdateCar(string vin, Car cartochanges);
    }

    class CarRepository : CRUD
    {
        VehicalsEntities entities;
         public CarRepository()
        {
            entities = new VehicalsEntities();
            

        }
        public ICollection<Car> GetCars()
        {
            return entities.Cars.ToList();
        }

        public void AddCar(Car obj)
        {
            entities.Cars.Add(obj);
            entities.SaveChanges();
        }
         public void DeleteCar(Car obj)
        {
            entities.Cars.Remove(obj);
            entities.SaveChanges();
        }

        public Car Findcar(string vin)
        {
            var car = entities.Cars.First(n => n.VIN == vin);
            if (car != null)
            {
                return car;
            }
            else
                return null;

        }

        public void UpdateCar(string vin, Car cartochange)
        {
            var cartoupdate = entities.Cars.Find(vin);
            cartoupdate.Make = cartochange.Make;
            cartoupdate.Model = cartochange.Model;
            cartoupdate.Year = cartochange.Year;
            cartoupdate.Price=cartochange.Price;
            entities.SaveChanges();

            
        }








    }
}
