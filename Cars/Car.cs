using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        //properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }

        public void Accelerate()
        {
            Speed += 5;
        }
        public void Brake()
        {
            Speed -= 5;
        }
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine size : " + EngineSize);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);

        }
        //constructor 
        public Car(string model, string color, double engineSize, bool fuzzyDices, int doorCount)
        {
            Model = model;
            Color = color;
            EngineSize = engineSize;
            FuzzyDices = fuzzyDices;
            DoorCount = doorCount;
            Speed = 0;
        }

        // destructor

        ~Car()
        {
            Console.WriteLine("Car object destroyed.");
        }
    }
}
