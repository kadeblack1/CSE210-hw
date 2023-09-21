using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        while (number != 0)
    
        {
        Console.Write("Enter a list of numbers, (type 0 when finished): ");
        String userResponse = Console.ReadLine();
        number = int.Parse(userResponse);

        if (number != 0)
        {
            numbers.Add(number);
        }
    }

        int sumResult = 0;

        foreach(int num in numbers)
        {
            sumResult += num;
        }

        Console.WriteLine($"The sum is {sumResult} "); 

        float averageResult =((float)sumResult) / numbers.Count;
        Console.WriteLine($"The average is: {averageResult}");
 
        int maxResult = numbers[0];

        foreach (int num in numbers)

        {
            if (num > maxResult)
            {
                maxResult = num;
            }
        }
        Console.WriteLine($"The max is {maxResult}");
    }
}