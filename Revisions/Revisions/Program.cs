using System;
using System.Collections.Generic;

public class Stack
{
    public static void Main(string[] args)
    {
        
       Stack<string>names = new Stack<string>();      
        names.Push("Sanjay");
        names.Push("Rahul");
        names.Push("Nitish");
        names.Push("Ramesh");
        names.Push("Jack");
        
       

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("-------------");
        Console.WriteLine( names.Peek());
        Console.WriteLine( names.Pop());
        Console.WriteLine("after pop, peek element: " + names.Peek());

    }
}


