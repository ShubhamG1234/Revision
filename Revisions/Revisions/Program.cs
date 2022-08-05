namespace Revision
{
    class IfElse
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 22;
            int c = 33;

            if (a>b)
            {
                Console.WriteLine("Greater Number is A");
            }
            else if (a<b)
            {
                Console.WriteLine("Greater Number is B");
            }
            else
            {
                Console.WriteLine("A is Equal to B");
            }


        }
    }
}