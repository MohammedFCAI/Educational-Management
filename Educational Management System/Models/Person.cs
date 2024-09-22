using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Management_System.Models
{
    public class Person
    {
        public string Name;
        public int id;
        public string username;
        public string password;
        public Person()
        {
        }
        public Person(string name, string username, string passwor, int id)
        {
            this.Name = name;
            this.username = username;
            this.password = passwor;
            this.id = id;
        }
        public bool CheckPass(string user, string pass)
        {
            if (this.username == user && this.password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
