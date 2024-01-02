namespace CricketPlayer
{
    public class Program
    {
        struct Player
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }

        static void Main(string[] args)
        {
            Player[] players = new Player[11];

            for (int i = 0; i < players.Length; i++)
            {
                Console.Write($"Please enter name of batsman {i + 1}: ");
                var name = Console.ReadLine();

                int score;

                do
                {
                    score = GetScore($"Please enter score of batsman {i + 1}: ");

                    if (score > 500)
                    {
                        Console.WriteLine("Score too large. Please enter score between 0 to 500.");
                    }
                    else if (score < 0)
                    {
                        Console.WriteLine("Score too small. Please enter score between 0 to 500");
                    }

                } while (score < 0 || score > 500);

                Player player = new Player() { Name = name, Score = score};

                players[i] = player;
            }

            //todo: bubble sort
            for (int i = 0; i < players.Length - 1; i++)
            {
                for (int j = 0; j < players.Length - 1 - i; j++)
                {
                    if (players[j].Score < players[j+1].Score)
                    {
                        Player temp = players[j];
                        players[j] = players[j + 1];
                        players[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Do you want to sort by name or by score? (enter N or S): ");
            char choice = Console.ReadLine().ToUpper()[0];

            if (choice == 'N')
            {
                Array.Sort(players, (x, y) => x.Name.CompareTo(y.Name));
            }

            Console.WriteLine("Sorted list:");
            foreach (var player in players)
            {
                Console.WriteLine($"Player's name: {player.Name} - Player's score: {player.Score}");
            }
        }

        static int GetScore(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(),out var score))
                {
                    return score;
                }
            }
        }
    }
}
