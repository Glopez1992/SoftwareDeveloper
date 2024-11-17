using System;

class Excercise
{
    static void Main()
    {
        // Declare Variables
        int c, thisIsAVariable, q76354, number, value, x, y;

        x = 1;
        y = 2;

        Console.WriteLine("This is a C#");
        Console.WriteLine("app");
        
        // Ask for user input
        Console.WriteLine("Please enter an integer number: ");
        
        value = int.Parse(Console.ReadLine());

        Console.WriteLine($"You entered: {value}");

        if (value != 7)
        {
            Console.WriteLine("The variable number is not equal to 7");
        }

        Console.WriteLine($"The result of x + y is: , {x + y}");
    } 
} 