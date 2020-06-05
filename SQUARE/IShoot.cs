﻿using battle_ship_in_the_oo_way_submarine101.OCEAN;
using static battle_ship_in_the_oo_way_submarine101.OCEAN.Ocean;

namespace battle_ship_in_the_oo_way_submarine101.SQUARE
{
    public interface IShoot
    {
        /// <summary>
        /// Check what type of square is this
        /// </summary>
        void CheckOccupation();

        /// <summary>
        /// Change the symbol of square in my array
        /// </summary>
        /// <param name="Row">from user input</param>
        /// <param name="Column">from user input</param>
        void SetProperMark(int Row, int Column)
        {
            Ocean myBoard = new MyBoard();
            Ocean enemyBoard = new EnemyBoard();
            // check at opponents board square type from array
            var whatItShouldBe = enemyBoard.fields[Row, Column];
            // change mark at my board to the mark of opponent
            Square isItOccupied = new Square.IsOccupied();
            if (whatItShouldBe == OccupationType.Empty)
            {
                myBoard.fields[Row, Column] = OccupationType.Miss;
            }
            else if (isItOccupied)
            {
                myBoard.fields[Row, Column] = OccupationType.Hit;
            }
        }

        /// <summary>
        /// If the square is a ship, hit it
        /// </summary>
        void HitThatShip();
    }
}