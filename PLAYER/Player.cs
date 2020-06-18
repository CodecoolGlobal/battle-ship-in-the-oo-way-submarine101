using System;
using System.Collections.Generic;
using System.Linq;

namespace battle_ship_in_the_oo_way_submarine101.PLAYER
{
    public class Player
    {
        public string Name;

        public Player(string name)
        {
            Name = name;
        }

        public static void PlayerMove()
        {
            var coordinates = GetTheCoords();
            int shipLength = ShipLength();
            bool direction = ShipDirection();
            SHIP.Ship.PlaceShip(coordinates.coordX,
                                coordinates.coordY,
                                shipLength,
                                direction);
        }

        public static (int coordX, int coordY) GetTheCoords()
        {
            int coordX = 0;
            int coordY = 0;
            bool validInput = false;
            string pattern = @"([a-zA-Z])([0-9].*)";
            var regex = new System.Text.RegularExpressions.Regex(pattern);
            var coordsRange = Enumerable.Range(0, 10);

            while (!validInput)
            {
                Console.WriteLine("Give XY");
                Console.Write("> ");
                string userInput = Console.ReadLine();
                if (userInput.Length > 3)
                {
                    continue;
                }
                string userInputX = regex.Split(userInput)[1];
                string userInputY = regex.Split(userInput)[2];
                coordX = UTILS.Utils.LetterToNumber(userInputX);
                validInput = int.TryParse(userInputY, out coordY);
                coordY--;
                if (coordX == 10 || !coordsRange.Contains(coordY))
                {
                    validInput = false;
                    continue;
                }

                //Console.ReadKey();
            }

            return (coordX, coordY);
        }

        public static int ShipLength()
        {
            int shipLength = 0;
            bool validInput = false;
            var lengthRange = Enumerable.Range(2, 4);

            while (!validInput)
            {
                Console.WriteLine("Set ship length:");
                Console.Write("> ");
                string userInput = Console.ReadLine();
                if (userInput.Length > 1)
                {
                    continue;
                }
                validInput = int.TryParse(userInput, out shipLength);
                if (!lengthRange.Contains(shipLength))
                {
                    validInput = false;
                    Console.WriteLine("The ship has unavailable length.");
                    continue;
                }

                //Console.ReadKey();
            }

            return shipLength;
        }

        public static bool ShipDirection()
        {
            bool direction = false;
            bool validInput = false;
            string userInput = "";

            while (!validInput)
            {
                Console.WriteLine("Do you want to place ship horizontal (h) or vertical (v)?");
                Console.Write("> ");
                userInput = Console.ReadLine().ToLower();
                if (userInput.Length > 1
                    || (userInput != "h" && userInput != "v"))
                {
                    continue;
                }
                validInput = true;
                
            }
            if (userInput == "h")
            {
                direction = true;
                return direction;
            }
            return direction;
        }
    }
}