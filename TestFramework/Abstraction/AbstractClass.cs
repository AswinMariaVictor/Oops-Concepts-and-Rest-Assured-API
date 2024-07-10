using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Sample
{
    public abstract class AbstractClass
    {
        public abstract string SetAbstractName();

        public virtual string GetAbstractName() // Virtual keyword if we implement the non abstact method from an abstract class to the base class
        {
            return "Dummy Abstrct";
        }

    }
}
