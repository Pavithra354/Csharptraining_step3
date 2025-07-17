using System;

namespace VehicleSystem
{
    // Base class
    class Vehicle
    {
        // virtual method: provides default behavior, can be overridden
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    // Derived class - Car
    class Car : Vehicle
    {
        // override: replaces the base class version
        public string Model { get; set; }
        public override void Start()
        {
            Console.WriteLine($"Car starts with a key{this.Model}.");
        }
        public Car(string modelNumber)
        {
            Model = modelNumber;
        }
    }

    // Derived class - Bike
    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike starts with a self-button.");
        }
    }

    // Derived class - Truck
    class Truck : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Truck starts by pressing the clutch and  with a key ignition");
            
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Base class references holding derived class objects
            Vehicle vehicle1 = new Car("abc");
            
            Vehicle vehicle2 = new Bike();
            Vehicle vehicle3 = new Truck();

            Console.WriteLine("---- Vehicle Startup Simulation ----");

            // Each call checks the actual object type at runtime
            vehicle1.Start();// Car version runs
            
            vehicle2.Start();  // Bike version runs
            vehicle3.Start();  // Truck version runs

            Console.ReadLine();// Keeps console open
            //Vehicle vehicle3 = new Truck();
            //vehicle3.Start();
        }
    }
}