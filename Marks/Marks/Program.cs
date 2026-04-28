// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string name;
        double mark1 = 0;
        double mark2 = 0;
        double mark3 = 0;
        double total;
        double average;
        string result;

        Console.WriteLine("Enter student name:");
        name = Console.ReadLine();

        // Subject 1
        Console.WriteLine("Enter mark for Subject 1:");
        while (!double.TryParse(Console.ReadLine(), out mark1))
        {
            Console.WriteLine("Invalid input, try again:");
        }

        // Subject 2
        Console.WriteLine("Enter mark for Subject 2:");
        while (!double.TryParse(Console.ReadLine(), out mark2))
        {
            Console.WriteLine("Invalid input, try again:");
        }

        // Subject 3
        Console.WriteLine("Enter mark for Subject 3:");
        while (!double.TryParse(Console.ReadLine(), out mark3))
        {
            Console.WriteLine("Invalid input, try again:");
        }

        total = mark1 + mark2 + mark3;
        average = total / 3;

        if (average >= 50)
        {
            result = "PASS";
        }
        else
        {
            result = "FAIL";
        }

        Console.WriteLine();
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Mark 1: " + mark1);
        Console.WriteLine("Mark 2: " + mark2);
        Console.WriteLine("Mark 3: " + mark3);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Result: " + result);

        Console.ReadLine(); // pause at end
    }
}
