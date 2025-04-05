using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("Pick a number, any number: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("lower");
            }

            else
            {
                Console.WriteLine("You got it!");
            }

        }                    
    }
}