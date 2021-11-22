//Create list containing rollno as key and Name as value and print details of students(use generic and non generic collection type both)

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //create a List of KeyValuePairs.
        Console.WriteLine("Students Details :");
        var list = new List<KeyValuePair<int , string>>();
        list.Add(new KeyValuePair<int ,string>(1,"Roger"));
        list.Add(new KeyValuePair<int , string>(2,"Joey"));
        list.Add(new KeyValuePair<int , string>(3,"Monica"));

        //loop over list and print pairs.
        foreach (var element in list)
        {
            Console.WriteLine(element);
           
            Console.ReadKey();
        }
    }
}