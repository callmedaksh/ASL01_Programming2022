using System;

namespace BusinessLogic
{
    public class Car
    {
        private const int OdometerLimit = 1_000_000;
        private const int DailyOdometerLimit = 10_000;

        private readonly string _brand;
        private readonly string _make;
        private readonly int _tankCapacity;
        private readonly double _fuelConsumption;

        private double _fuelLevel;
        private double _odometer;
        private double _dailyOdometer;

        public Car(string brand, string make, int tankCapacity, double fuelConsumption)
        {
            //checks are your homework
            _brand = brand;
            _make = make;
            _tankCapacity = tankCapacity;
            _fuelConsumption = fuelConsumption;
        }

        public void AddFuel(int fuel)
        {
            if (fuel < 1)
                throw new ArgumentException(nameof(fuel), "Fuel cannot be negative");

            _fuelLevel += fuel;

            if (_fuelLevel > _tankCapacity)
                _fuelLevel = _tankCapacity;
        }

        public int FuelLevel => (int)_fuelLevel;

        public int Odometer => (int)_odometer;

        public int DailyOdometer => (int)_dailyOdometer;

        public void Drive(double distance)
        {
            if (distance < 0)
                throw new ArgumentException(nameof(distance), "Distance cannot be negative");

            var maximumDistance = _fuelLevel / _fuelConsumption * 100;
            
            if (distance > maximumDistance)
            {
                _odometer += maximumDistance;
                _dailyOdometer += maximumDistance;
                _fuelLevel = 0;
            }
            else
            {
                _odometer += distance;
                _dailyOdometer += distance;
                _fuelLevel -= distance * _fuelConsumption / 100;
            }

            if (_dailyOdometer >= DailyOdometerLimit) _dailyOdometer -= DailyOdometerLimit;
            if (_odometer >= OdometerLimit) _odometer -= OdometerLimit;
        }
    }
}
