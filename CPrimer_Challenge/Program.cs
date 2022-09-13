using System;
/*Challenge 1:
Write a program that asks the user for a number (Console.ReadLine()), over and over again, 
forever, until he stops giving a number (just presses enter).
Store every number in a List.
At the end of the program, print out the largest and the smallest value the user entered.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        string userInput;
        int number;

        do
        {
            Console.WriteLine("Please enter a number. Press Enter to quit");
            userInput = Console.ReadLine();
            bool numberInput = int.TryParse(userInput, out number);
            if (number < 1)
            {
                continue;
            }
            else
            {
                numberList.Add(number);
            }

        }
        while (userInput != "");

        long minNum = numberList.AsQueryable().Min();
        long maxNum = numberList.AsQueryable().Max();
        Console.WriteLine($"The smallest number in the list is {minNum}, and the largest is {maxNum}");
    }
    
}