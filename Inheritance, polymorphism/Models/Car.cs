using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public abstract class Car
    {
        public double Speed { get; protected set; } = 20;
        public bool Engine { get; protected set; } = false;

        public void Start() 
        {
            Engine = true;
            Console.WriteLine("Engine On.");
        }
        public void Stop() 
        {
            Engine = false;
            Console.WriteLine("Engine Off.");
        }
        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerating");
            Console.WriteLine($"{Speed}km/h");
        }
    }
    public class Truck : Car
    {
        public override void Accelerate()
        {
            base.Accelerate();
            Speed += 5;
            Console.WriteLine($"After accelerate {Speed} km/h");
        }
    }
    public class SportCar : Car 
    {
        public override void Accelerate()
        {
            base.Accelerate();
            Speed += 20;
            Console.WriteLine($"After accelerate {Speed} km/h");
        }
    }

    public class Race 
    {
        public void StartOfRace() 
        {
            Truck truck = new Truck();
            SportCar sportCar = new SportCar();

            List<Car> cars = new List<Car>
            {
                truck,sportCar  
            };

            foreach (var car in cars) 
            {
                car.Start();
                car.Accelerate();
            }
        }
    }
}
