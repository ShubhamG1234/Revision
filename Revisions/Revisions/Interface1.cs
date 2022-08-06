using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
     interface InterfaceOne
    {
        void methodOne();
    }
    interface InterfaceTwo
    {
        void methodTwo();
    }
    public class ClassOne : InterfaceOne, InterfaceTwo
    {
        public void methodOne()
        {
            Console.WriteLine("Implementing first method");
        }
        public void methodTwo()
        {
            Console.WriteLine("Implement second method");
        }
    }
}
