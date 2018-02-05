using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            persons.Add(new Person { Firstname = "Jani", Lastname = "Immonen", SocialSecurityNumber = "123214124" });
            persons.Add(new Person { Firstname = "Pertti", Lastname = "Kettu", SocialSecurityNumber = "7457547" });
            persons.Add(new Person { Firstname = "Damien", Lastname = "Bolognese", SocialSecurityNumber = "47554334" });

            //yhen tyypin data
            //Console.WriteLine(persons.ElementAt(0).ToString());
            //
            //Console.WriteLine(persons[0].ToString());

            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
                if (person == persons.Last())
                {
                    Console.WriteLine("Last!");
                }
            }

            //persons.Sort((x, y) => x.Lastname.CompareTo(y.Lastname)); // fuckken magic
            persons.Sort();
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }

            /*var names = new List<string>
            {
                "Anna",
                "Pekka",
                "Kimmo",
                "Daavetti"
            };

            names.ForEach(name => Console.WriteLine($"Hello {name}")); //dollarilla muuttujia voi laittaa lainausmerkkien sisään
            */
            /*
             names.ForEach(ShowInConsole);
             */
        }

        /*private static void ShowInConsole(string txt)
        {
            Console.WriteLine(txt);
        }
        */
    }
}
