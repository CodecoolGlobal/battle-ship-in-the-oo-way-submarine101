using battle_ship_in_the_oo_way_submarine101.OCEAN;
using battle_ship_in_the_oo_way_submarine101.PLAYER;
using System;
using System.IO;

namespace battle_ship_in_the_oo_way_submarine101
{
    public class MainLogic
    {
        public static Player EnemyPlayer;
        public static Player MainPlayer;

        public static void AsciiArt()
        {
            try
            {
                // Open the text file using a stream reader.
                using StreamReader sr =
                    new StreamReader("NewFile1.txt");
                // Read the stream to a string, and write the string to the console.
                Console.ForegroundColor = ConsoleColor.Green;
                string line = sr.ReadToEnd();
                Console.WriteLine(line);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static bool IsPlaying()
        {
            if (EnemyPlayer.PlayerShips.Count == 0 || MainPlayer.PlayerShips.Count == 0)
            {
                return false;
            }
            return true;
        }

        public static void Logic()
        {
            AsciiArt();
            string playerName = Player.GetTheInput("PLAYER 1 - Type in your name");
            (var player1, var player1Board, var emptyPlayer1Board) = Player.CreateNewPlayer(playerName);
            MainPlayer = player1;
            playerName = Player.GetTheInput("PLAYER 2 - Type in your name or hit ENTER to play with computer");
            (var player2, var player2Board, var emptyPlayer2Board) = Player.CreateNewPlayer(playerName);
            EnemyPlayer = player2;
            Console.Clear();
            bool firstRound = true;

            while (IsPlaying() || firstRound)
            {
                AsciiArt();
                Console.WriteLine($"This is {player1.Name} turn.");
                Ocean.PrintBoard(player1Board, emptyPlayer2Board);
                player1.Move(player1Board,
                                  emptyPlayer2Board,
                                  player2Board, player2.PlayerShips);
                Console.WriteLine("Press any button to switch players.");
                Console.ReadKey();
                Console.Clear();
                AsciiArt();
                Console.WriteLine($"This is {player2.Name} turn.");
                if (player2.Name != "AI")
                {
                    Ocean.PrintBoard(player2Board, emptyPlayer1Board);
                }
                player2.Move(player2Board,
                                  emptyPlayer1Board,
                                  player1Board, player1.PlayerShips);
                firstRound = false;
                if (player2.Name != "AI")
                {
                    Console.WriteLine("Press any button to switch players.");
                    Console.ReadKey();
                }
                Console.Clear();
            }

            AsciiArt();
            if (EnemyPlayer.PlayerShips.Count == 0)
            {
                Console.WriteLine($"\n{player1.Name} wins!\n");
            }
            else
            {
                Console.WriteLine($"\n{player2.Name} wins!\n");
            }
            Console.WriteLine("Press any button to exit.");
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}