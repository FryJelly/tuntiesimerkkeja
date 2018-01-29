using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
    abstract class Shape
    {
        public string Name { get; set; }

        public Shape()
        {
        }

        public Shape(string name)
        {
            Name = name;
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something!");
        }

        public abstract void Draw();
    }
}
