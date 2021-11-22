//Write a program to accept month number from user and print no of day in month. For eg. If user enters 1 then “31 days in month”(use switch case) 
using System;

public class csharpExercise
{
    static void Main(string[] args)
    {

        int monthnumber;
        Console.WriteLine("Enter month number(1-12): ");
        monthnumber = Convert.ToInt32(Console.ReadLine());

        switch (monthnumber)
        {
            case 1:
                Console.WriteLine("31 days");
                break;
            case 2:
                Console.WriteLine("28 or 29 days");
                break;
            case 3:
                Console.WriteLine("31 days");
                break;
            case 4:
                Console.WriteLine("30 days");
                break;
            case 5:
                Console.WriteLine("31 days");
                break;
            case 6:
                Console.WriteLine("30 days");
                break;
            case 7:
                Console.WriteLine("31 days");
                break;
            case 8:
                Console.WriteLine("31 days");
                break;
            case 9:
                Console.WriteLine("30 days");
                break;
            case 10:
                Console.WriteLine("31 days");
                break;
            case 11:
                Console.WriteLine("30 days");
                break;
            case 12:
                Console.WriteLine("31 days");
                break;
            default:
                Console.WriteLine("Invalid input");
                Console.WriteLine("enter month number between 1-12");
                break;


        }
        Console.ReadLine();
        Console.ReadKey();

    }
}