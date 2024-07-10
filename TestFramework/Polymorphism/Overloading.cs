using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Polymorphism
{
    public class Overloading
    {
        private string name;
        public Overloading() 
        {
            
        }
        public string SetName(string name)
        {
            return this.name = name;
        }
        public string SetName(string firstName, string lastname)
        {
            return firstName + lastname;
        }
        public string GetName(string name) 
        {
            int index = 0;
            return SetName(name);
        }
        public bool GetName(string name, string lastName)  // In Overloading return type can be different.
        {                                                  // In Over riding return should be the same.
            return true;                                   // But 
        }

        static void Main(string[] args)
        {
            Overloading o = new Overloading();
            o.GetName("Aswin", "Victor");
            o.GetName("Aswin");
        }
    }
}
