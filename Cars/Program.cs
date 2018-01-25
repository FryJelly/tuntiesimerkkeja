using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car instance
            Car datsun = new Car("Datsun 100A", "red", 1.0, true, 2);
            Car porcshe = new Car("Porcshe 911 RS3", "silver", 3.2, false, 2);
            Car toyota = new Car("Toyota Camry", "blue", 2.0, true, 4);
            // display car data
            datsun.PrintData();
            porcshe.PrintData();
            toyota.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            datsun.Accelerate();
            // display car data again, notice changed speed value!
            datsun.PrintData();
            Console.ReadLine();
        }
    }
}
