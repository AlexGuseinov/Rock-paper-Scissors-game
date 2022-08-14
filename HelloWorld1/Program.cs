namespace system
{
    public class app
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            string computer;
            string player;
            bool playAgain = true;
            string response;

            while (playAgain)
            {
                response = " ";
                player = " ";
                computer = " ";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {

                    System.Console.Write("Rock paper or scissors?");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;

                    case 2:
                        computer = "PAPER";
                        break;

                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                System.Console.WriteLine("computer: " + computer);
                System.Console.WriteLine("player: " + player);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            System.Console.WriteLine("it's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            System.Console.WriteLine("u lose..");
                        }
                        else
                        {
                            System.Console.WriteLine("u won!!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            System.Console.WriteLine("u won :)");
                        }
                        else if (computer == "PAPER")
                        {
                            System.Console.WriteLine("it's a draw..");
                        }
                        else
                        {
                            System.Console.WriteLine("u lose  (");
                        }
                        break;

                    case "SCISSOR":
                        if (computer == "ROCK")
                        {
                            System.Console.WriteLine("u lose :(");
                        }
                        else if (computer == "PAPER ")
                        {
                            System.Console.WriteLine("u won :)");
                        }
                        else
                        {
                            System.Console.WriteLine("it's a draw");
                        }
                        break;

                }

                System.Console.WriteLine("would u like to play again ? (Y/N) ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;

                }
                else
                {
                    playAgain = false;
                }

            }
        }

    }
}