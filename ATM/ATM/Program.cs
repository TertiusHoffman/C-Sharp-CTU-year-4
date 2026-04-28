// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string name;
        double balance = 1000;
        double amount;
        string input;

        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();

        Console.WriteLine("Hello " + name);
        Console.WriteLine("Your balance is: R" + balance);

        Console.WriteLine("Enter amount to withdraw:");
        input = Console.ReadLine();

        // check if number
        while (double.TryParse(input, out amount) == false)
        {
            Console.WriteLine("Wrong input, try again:");
            input = Console.ReadLine();
        }

        if (amount > balance)
        {
            Console.WriteLine("Not enough money");
        }
        else
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
            }
            else
            {
                balance = balance - amount;

                Console.WriteLine("You withdrew: R" + amount);
                Console.WriteLine("Balance left: R" + balance);
                Console.WriteLine("Time: " + DateTime.Now);
            }
        }

        Console.WriteLine("Thank you " + name);
        Console.ReadLine();
    }
}
