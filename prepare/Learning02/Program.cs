using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is The magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();

        int guess = -1;
        
        while (guess != magicNumber)
        {   
    
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
           
           
            if (magicNumber > guess)
            {
                Console.WriteLine("higher");
            }
            else if (magicNumber < guess)
            {
                   Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("correct");
            }

        }    
    
    }

}