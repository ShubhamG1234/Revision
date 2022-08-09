using System;
using System.Collections.Generic;

public class Dictionary
{
    public static void Main(string[] args)
    {

        Dictionary<int, string> names = new Dictionary<int,string>();      
        names.Add(1,"Sanjay");
        names.Add(2,"Rahul");
        names.Add(3,"Nitish");
        names.Add(4,"Ramesh");
        names.Add(5,"Jack");
        names.Remove(5);

       
       

        foreach (KeyValuePair<int,string> keyValues in names)
        {
            Console.WriteLine(keyValues.Key+" "+ keyValues.Value);
        }

        Console.WriteLine("-------------");
        

    }
}


