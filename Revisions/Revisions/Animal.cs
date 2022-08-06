using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    abstract class Animal                 
    {                                           //abstract class
        public abstract void eat();             //abstract method
        public void hunts()
        {
            Console.WriteLine("hunting");
        }         
    }
    class Tiger : Animal         //derived class or child class
    {
        public override void eat()
        {
            Console.WriteLine("eating flesh");
        }
    }
     class BabyTiger : Tiger
    {
        public override void eat()
        {
            Console.WriteLine("eating meat");
        }
    }
}
