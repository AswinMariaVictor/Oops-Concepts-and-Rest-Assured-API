using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Sample
{
    public class AccessAbstract
    {
        static void Main(string[] args)
        {
            AbstractClass obj = new Program();
            obj.GetAbstractName();
            obj.SetAbstractName();
        }
    }
}
