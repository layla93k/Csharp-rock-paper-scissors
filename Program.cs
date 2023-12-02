using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to my game of Rock Paper Scissors!");
            while(playerScore != 3 && enemyScore != 3) 
            {
                Console.WriteLine($"Player score - {playerScore}. Enemy score - {enemyScore}");
                Console.WriteLine("Please enter 's' for scissors, 'r' for rock and 'p' for paper.");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if(enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");
                    switch(playerChoice)
                    {
                        case "r":
                        Console.WriteLine("It's a tie!");
                        break;
                        case "p":
                        Console.WriteLine("You've won this round!");
                        playerScore++;
                        break;
                        default:
                        Console.WriteLine("Enemy has won this round!");
                        enemyScore++;
                        break;
                    }
                }
                else if(enemyChoice == 1)
                {
                Console.WriteLine("Enemy chooses paper");
                switch(playerChoice)
                {
                    case "r":
                    Console.WriteLine("Enemy has won this round!");
                    enemyScore++;
                    break;
                    case "p":
                    Console.WriteLine("It's a tie!");
                    break;
                    case "s":
                    Console.WriteLine("You've won this round!");
                    playerScore++;
                    break;
                }
                }
                else
                {
                Console.WriteLine("Enemy chooses scissors.");
                switch(playerChoice)
                {
                    case "r":
                    Console.WriteLine("You've won this round!");
                    playerScore++;
                    break;
                    case "p":
                    Console.WriteLine("Enemy wins this round!");
                    enemyScore++;
                    break;
                    case "s":
                    Console.WriteLine("It's a tie!");
                    break;

                }
                }
        }
        if(playerScore == 3)
        {
            Console.WriteLine("Congratulations you've won the game!");
        }
        else 
        {
            Console.WriteLine("Enemy has won, better luck next time!");
        }
    }
}
}