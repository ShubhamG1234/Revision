using System;
using System.Collections.Generic;

public class Queue
{
    public static void Main(string[] args)
    {
        
       Queue<string>names = new Queue<string>();      
        names.Enqueue("Sanjay");
        names.Enqueue("Rahul");
        names.Enqueue("Nitish");
        names.Enqueue("Ramesh");
        names.Enqueue("Jack");
        
       

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("-------------");
        Console.WriteLine( names.Peek());
        Console.WriteLine( names.Dequeue());
        Console.WriteLine("after pop, peek element: " + names.Peek()); //next element name

    }
}


