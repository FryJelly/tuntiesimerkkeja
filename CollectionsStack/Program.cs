using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            //stack
            /*// create stack for strings
            Stack<string> stackStrings = new Stack<string>();

            stackStrings.Push("first");
            stackStrings.Push("second");
            stackStrings.Push("third");

            //get first
            Console.WriteLine(stackStrings.Peek());

            // print all
            foreach (string s in stackStrings)
            {
                Console.WriteLine(s);
            }

            // get and delete first
            string temp = stackStrings.Pop();
            Console.WriteLine("Just popped: {0}", temp);
            Console.WriteLine("Stack Count is {0}", stackStrings.Count); // count is 2*/

            //queue
            /*// create queue instance
            Queue<string> queue = new Queue<string>();
            // add values
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            // get first and leave it to collection
            string first = queue.Peek();
            Console.WriteLine("first in queue is {0}", first); // first
            Console.WriteLine("Count is {0}", queue.Count); // 3
                                                            // get first and remove it from collecion
            first = queue.Dequeue();
            Console.WriteLine("first in queue is {0}", first);  // first
            Console.WriteLine("Count is {0}", queue.Count); // 2

            */

            //Dictionary
            // create persons collection
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            // create persons
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person person2 = new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" };
            Person person3 = new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" };
            // add persons to collection
            persons.Add(person1.SocialSecurityNumber, person1);
            persons.Add(person2.SocialSecurityNumber, person2);
            persons.Add(person3.SocialSecurityNumber, person3);
            // find person with key
            string ssn = "020292-222A";
            Person found;
            if (persons.TryGetValue(ssn, out found))
            {
                Console.WriteLine("Person with social security number {0} is {1}.", ssn, found.ToString());
                // output
                //  Person with social security number 020292-222A is Matti.

            }
            else
            {
                Console.WriteLine("Person with social security number {0} is {1}.", ssn);
            }

            // go through all keys
            foreach (string key2 in persons.Keys)
            {
                Console.WriteLine(key2);
            }
            //go through all values
            foreach (Person person in persons.Values)
            {
                Console.WriteLine(person);
            }
            // go through all keys and values
            foreach (KeyValuePair<string, Person> kvp in persons)
            {
                Console.WriteLine("{0}:{1}", kvp.Key, kvp.Value);
            }
            // remove object
            if (persons.ContainsKey(ssn))
            {
                persons.Remove(ssn);
            }

            // size
            Console.WriteLine("Collection size is {0}", persons.Count); // 2
        }
    }
}
