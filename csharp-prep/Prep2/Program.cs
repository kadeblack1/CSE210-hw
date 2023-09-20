using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade percentage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade = "";

        if  (percent >= 90)
        {
        grade = "A";
        }
        else if (percent>= 80)
        {
        grade = "B";
        }
        else if (percent >= 70)
        {
        grade = "C";
        }
        else if (percent >= 60)
        {
        grade = "D";
        }
        else if (percent >= 50)
        {
        grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (percent >= 70) 
        {
            Console.WriteLine("You passed");
        }
        if (percent <=60)
        {
            Console.WriteLine("You Failed");
        }


        }
    }