namespace Revision
{
    class TakeUserInput
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your Name:");
            string yourName = Console.ReadLine();       //taking string input

            Console.WriteLine("Good Mornig:" + yourName);


            
            Console.Write("What is your weight:");
            int weight = Convert.ToInt16(Console.ReadLine()); //taking number input
           
            Console.WriteLine("Your Weight is:" + weight);


        }
    }
}