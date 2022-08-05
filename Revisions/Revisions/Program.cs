namespace Revision
{
    class Operator
    {
        static void Main(string[] args)
        {
            int a = 12+10;
            int b = 22;
            int c = 33;    

            c += 3;                 //assignment operator

            
            Console.WriteLine(a + b);  //Arithmatic operator,addition
            Console.WriteLine(a % b);  //Arithmatic operator,modulus reminder
           
            Console.WriteLine(a > b);  //Comparison Operators
            
            Console.WriteLine(c > b && c > a);  //Condition Operators




        }
    }
}