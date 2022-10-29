using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    static internal class MyClass<T> where T : new()
    {
        public static T FactoryMethod() 
        {
            return new T();
        }
    }
}
