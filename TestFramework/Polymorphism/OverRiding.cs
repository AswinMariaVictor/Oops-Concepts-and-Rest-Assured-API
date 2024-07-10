using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Polymorphism
{
    public class OverRidingOne
    {
        public virtual string EmployeeName(string name)
        {
            return "Aswin" + name;
        }
    }
    public class OverRidingTwo : OverRidingOne
    {
        public override string EmployeeName(string name)
        {
            return name;
        }
    }

    public class OverRidingThree : OverRidingOne
    {
        public override string EmployeeName(string name)
        {
            return name;
        }
    }

    public class MainClass
    {
        static void Main(string[] arg)
        {
            OverRidingOne obj = new OverRidingOne();
            OverRidingOne obj1 = new OverRidingTwo();
            OverRidingOne obj2 = new OverRidingThree();
            obj.EmployeeName("One");
            obj1.EmployeeName("Two");
            obj2.EmployeeName("Three");
        }
    }
}
