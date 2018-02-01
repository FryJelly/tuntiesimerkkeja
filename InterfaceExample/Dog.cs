using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Dog : Animal, IConnectionStatusListener
    {

        public override void Talk()
        {
            Console.WriteLine("WOOOOOOOOF!");
        }
        public void OnConnectionStarted()
        {
            Console.WriteLine("DOG: OnConnectionStarted");
        }
        public void OnConnectionSuccess()
        {
            Console.WriteLine("DOG: OnConnectionSuccess - WOOF WOOF");
        }
        public void OnConnectionFailed()
        {
            Console.WriteLine("DOG: OnConnectionFailed - whine...");
        }
    }
}
