using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    public class User
    {
        private Luser _luser;

        public User()
        {
        }

        public User(Luser luser)
        {
            this._luser = luser;
        }

        ~User()
        {
            Console.WriteLine("User is destructed");
        }

        public void PrintName()
        {
            Console.WriteLine("User uses luser " + _luser.Name);
        }

    }

    public class Luser
    {
        public string Name;

        public Luser(string name)
        {
            this.Name = name;
        }

        ~Luser()
        {
            Console.WriteLine("Luser " + this.Name + " is destructed");
        }
    }
}
