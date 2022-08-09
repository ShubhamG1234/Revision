using System;
using System.Collections.Generic;

public class LinkedList
{
    public static void Main(string[] args)
    {
        
       var names = new LinkedList<string>();      
        names.AddLast("Sanjay");
        names.AddLast("Rahul");
        names.AddLast("Nitish");
        names.AddLast("Ramesh");
        names.AddFirst("Jack");

        LinkedListNode<string> node = names.Find("Ramesh");
        names.AddBefore(node,"Rita");
        names.AddAfter(node,"Tina");
       

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("-------------");
        

    }
}


