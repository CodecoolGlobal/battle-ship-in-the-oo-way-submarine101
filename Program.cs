﻿using battle_ship_in_the_oo_way_submarine101.OCEAN;
using battle_ship_in_the_oo_way_submarine101.PLAYER;
using battle_ship_in_the_oo_way_submarine101.SHIP;
using battle_ship_in_the_oo_way_submarine101.SQUARE;
using System;
using static battle_ship_in_the_oo_way_submarine101.MainLogic;

namespace battle_ship_in_the_oo_way_submarine101
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocean ocean = new Ocean("XD");
            Ship ship1 = new Ship("Destroyer", 2);
            MainLogic.Test();
            Ocean.PrintBoard();
            // Ocean.PrintBoard();
            // //Square.UpdateOccupationToShip(2, 2);
            Ship.PlaceShip(1, 2, ship1.Life, true);
            Ocean.PrintBoard();
            // Ocean.PrintBoard();
            // Console.Read();
            // Square.Shoot(2, 3);
            // Ocean.PrintBoard();
        }
    }
}
