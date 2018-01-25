using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Sampo";
            person.LastName = "Immo";
            person.Address = "Jyväskylä";
            person.Age = 24;
            person.PhoneNumber = "040-1234567";
            Console.WriteLine(person.ToString());

            Teacher jani = new Teacher("Jani", "Immonen", "unavailable");
            jani.Address = "Kuokkalan silta 1";
            jani.Age = 24;
            Console.WriteLine(jani.ToString());

            Student pekka = new Student("Pekka", "Pouta", "K2390");
            pekka.Address = "Opiskelijakuja 69";
            pekka.Age = 19;
            Console.WriteLine(pekka.ToString());

            List<Person> people = new List<Person>();

            for (int i = 0; i < 20; i++)
            {
                if (i<5)
                {
                    people.Add(new Person());
                }
                else if (i < 12)
                {
                    people.Add(new Teacher());
                }
                else
                {
                    people.Add(new Student());
                }
                people.Add(new Person());
            }

            foreach (Person personInPeople in people)
            {
                Console.WriteLine(personInPeople.ToString());
            }
        }
    }
}
