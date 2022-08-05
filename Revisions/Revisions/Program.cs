namespace Revision
{
    class SwitchCase
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            


                switch (age)
            {
                case <18 :
                    Console.WriteLine("You are not Eligible");
                    break;
                case >18:
                    Console.WriteLine("you are Eligible");
                    break;
                default:
                    Console.WriteLine("welcome");
                    break;
               




            }

        }
    }
}