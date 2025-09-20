using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playagain = true;
        string userChoice;
        string programChoice;
        int programInput;

        while (playagain)
        {
            programInput = random.Next(1,4);

            programChoice = programInput switch
            {
                1 => "rock",
                2 => "paper",
                3 => "scissor",
            };

            Console.WriteLine("Enter rock, paper or scissor:");
            userChoice = Console.ReadLine();

            
        }

        Console.ReadKey();
    }
}