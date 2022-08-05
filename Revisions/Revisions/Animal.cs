using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    public class Animal                 
    {                                           //RunTime polymorphism
        public virtual void eat()              //Method ovrriding
        {
            Console.WriteLine("eating");    
        }           
    }
    public class Tiger : Animal         //derived class or child class
    {
        public override void eat()
        {
            Console.WriteLine("eating flesh");
        }
    }
    public class BabyTiger : Tiger
    {
        public override void eat()
        {
            Console.WriteLine("eating meat");
        }
    }
}
