using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Sample;

namespace TestFramework
{
    public class Program : AbstractClass, Interface1
    {
        public static string SetName() => "aswin";

        public static void GetName2()
        {
            SetName();
        }
        static void Main(string[] args)
        {
            GetName2();
        }

        public string SetInterfaceName()
        {
            return "Interface";
        }

        public override string SetAbstractName() // Override keyword for abstract method
        {
            return "MainAbstract";
        }

        public override string GetAbstractName() // Override keyword if we implement the non abstact method from an abstract class
        {
            return "Original Abstrct";
        }
    }
}
