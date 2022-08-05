namespace Revision
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            int num = 18;
            long mobileNo =num;  //Implicit Casting,converting lower data type to higher
            
            Console.WriteLine(num);




            double theDouble = 3.142;
            int theInt = (int) theDouble;   //Explicit casting

            Console.WriteLine(theDouble);
            Console.WriteLine(theInt);


            Console.WriteLine(Convert.ToString(theInt));  //By using Conversion method
            Console.WriteLine(Convert.ToDouble(num));

            


         }
    }
}