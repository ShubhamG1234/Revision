using Revisions;

namespace Revision
{
    class Constructors
    {
        static void Main(string[] args)
        {

            Car Ferrari = new Car("F1", "rainbow", 1920);    //passing multiple arguments
           

            Car RangeRover = new Car("velar", "black", 2022);
            

            Console.WriteLine(Ferrari.brand);
            Console.WriteLine(RangeRover.year);
                               
        }
    }
}