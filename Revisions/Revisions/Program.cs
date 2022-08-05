using Revisions;

namespace Revision
{
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Animal animal ;

            animal = new Animal();
            animal.eat();

            animal = new Tiger();
            animal.eat();

            animal = new BabyTiger();
            animal.eat();



        }
    }
}