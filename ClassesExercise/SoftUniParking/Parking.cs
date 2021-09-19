using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;
        
        public List<Car> Cars { get => cars; set => cars = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public Parking(int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
        }
        public int Count
            => cars.Count();

        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegNumber == car.RegNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Count == capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!cars.Any(c => c.RegNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(cars.First(c => c.RegNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
            => cars.FirstOrDefault(c => c.RegNumber == registrationNumber);

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                cars.RemoveAll(c => c.RegNumber == registrationNumber);
            }
        }
    }
}
