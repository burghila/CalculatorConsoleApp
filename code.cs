using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number and store it in a variable.
        Console.WriteLine("Enter a number:");
        long input = Convert.ToInt64(Console.ReadLine());

        // Multiply the number by 50 and print the result.
        long multiplied = input * 50;
        Console.WriteLine("Number multiplied by 50: " + multiplied);

        // Prompt the user to enter another number.
        Console.WriteLine("Enter another number:");
        long input2 = Convert.ToInt64(Console.ReadLine());

        // Add 25 to the number and print the result.
        long added = input2 + 25;
        Console.WriteLine("Number plus 25: " + added);

        // Prompt the user to enter another number.
        Console.WriteLine("Enter another number:");
        double input3 = Convert.ToDouble(Console.ReadLine());

        // Divide the number by 12.5 and print the result.
        double divided = input3 / 12.5;
        Console.WriteLine("Number divided by 12.5: " + divided);

        // Prompt the user to enter another number.
        Console.WriteLine("Enter another number:");
        long input4 = Convert.ToInt64(Console.ReadLine());

        // Check if the number is greater than 50 and print the result.
        bool isGreaterThanFifty = input4 > 50;
        Console.WriteLine("Is the number greater than 50? " + isGreaterThanFifty);

        // Prompt the user to enter another number.
        Console.WriteLine("Enter another number:");
        long input5 = Convert.ToInt64(Console.ReadLine());

        // Calculate the remainder when the number is divided by 7 and print the result.
        long remainder = input5 % 7;
        Console.WriteLine("Remainder when divided by 7: " + remainder);

        // Keep the console window open until the user presses a key.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
