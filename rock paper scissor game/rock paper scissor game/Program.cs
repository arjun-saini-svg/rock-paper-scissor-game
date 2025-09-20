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
        string result;

        while (playagain)
        {
            programInput = random.Next(1,4);

            programChoice = programInput switch
            {
                1 => "rock",
                2 => "paper",
                3 => "scissor",
                _ => "idk"
            };

            switch (programChoice)
            {
                case "idk":
                    Console.WriteLine("program didn't choose");
                        break;
            };

            Console.WriteLine("Enter rock, paper or scissor:");
            userChoice = Console.ReadLine();

            result = (userChoice, programChoice) switch
            {
                ("rock", "paper") => "You lose",
                ("rock", "scissor") => "You win",
                ("paper", "scissor") => "You lose",
                ("paper", "rock") => "You win",
                ("scissor", "paper") => "You win",
                ("scissor", "rock") => "You lose",
                var (u, p) when u == p => "Its a TIE",
            };

            Console.WriteLine($"{result}");
            Console.WriteLine($"program's choice was {programChoice}");

            Console.WriteLine("Would you like to play again? Y/N");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Y":
                    playagain;
                    break;

                case "N":
                    playagain = false;
                    break;
            }
        }

        Console.ReadKey();
    }
}