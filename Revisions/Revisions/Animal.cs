using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    public class Animal                 // Base or Parent class
    {                                   //MultiLevel Inheritance
        public void eat()              //Method
        {
            Console.WriteLine("eating");    
        }           
    }
    public class Tiger : Animal         //derived class or child class
    {
        public void roars()
        {
            Console.WriteLine("roaring");
        }
    }
    public class BabyTiger : Tiger
    {
        public void sleeps()
        {
            Console.WriteLine("zzzzz");
        }
    }
}
