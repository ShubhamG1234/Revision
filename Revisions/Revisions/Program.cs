using Revisions;

namespace Revision
{
    class Members
    {
        static void Main(string[] args)
        {

            Car Ferrari = new Car();    //creating objects
            Ferrari.brand = "F1";       
            Ferrari.color = "rainbow";      //assigning valueas
            Ferrari.year =1920 ;

            Car RangeRover = new Car();
            RangeRover.brand = "velar";
            RangeRover.color = "black";
            RangeRover.year = 2022;

            Console.WriteLine(Ferrari.brand);
            Console.WriteLine(RangeRover.brand);
            Ferrari.raceCar();                      //calling method
        }
    }
}