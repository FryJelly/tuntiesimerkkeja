using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCats(99);
            Console.WriteLine("CatCount: " + Cat.CatCount());
        }
        static void CreateCats(int num)
        {
            int i;
            for (i = 0; i < 99; i++)
            {
                Cat cat = new Cat();
            }
        }
    }
}
