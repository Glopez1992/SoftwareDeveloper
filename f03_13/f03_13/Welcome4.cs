// Fig. 3.13: Welcome4.cs
// Inserting content into a string with string interpolation.
using System;class Welcome4{
    // Main method begins execution of C# app
    static void Main()
    {
        string person = "Gisel Lopez"; // variable that stores the string "Gisel"
        int hour = 40;
        decimal rate = 25.99m;
        decimal totalPay = hour * rate;
        Console.WriteLine($"Welcome to C# Programming, {person}!");
        Console.WriteLine();
        Console.WriteLine($"Name: {person}!\nHours Worked: {hour}" + $"\nRate: {rate}\nTotal Pay: {totalPay}");
    } // end Main
} // end class Welcome4