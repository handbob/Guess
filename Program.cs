namespace Guess;

using System;

public class Program {
    public static void Main(String[] args) {
        Console.Write("Think a number from range 1 to 10.\nEnter number: ");
        var number = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        var thinkingNumber = Random.Shared.Next(1, 10);

        if (number == thinkingNumber) {
            Console.WriteLine("You have found match.");
        }
        else {
            do {
                Console.Write("Try again.\nEnter number: ");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            while (number != thinkingNumber);
        }
        Console.WriteLine();
        Console.WriteLine($"Searching number {thinkingNumber}");
        Console.WriteLine($"Your number {number}");
    }
};