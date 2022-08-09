using System;
using System.Collections.Generic;

public class HashSet
{
    public static void Main(string[] args)
    {
        var names = new HashSet<string>(){"Sanjay","Rahul","Nitish","Ramesh","Jack"};

        //var names = new HashSet<string>();     //  list of strings 
        //names.Add( "Sanjay");
        //names.Add( "Rahul");
        //names.Add( "Nitish");
        //names.Add( "Ramesh");
        //names.Add( "Jack");


        foreach (var name in names)          // iterating list element 
        {
            Console.WriteLine(names);
        }
    }
}
