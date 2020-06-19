using battle_ship_in_the_oo_way_submarine101.SQUARE;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace battle_ship_in_the_oo_way_submarine101.OCEAN
{
    public class Ocean
    {
        private string Name;
        static int CoordX;
        static int CoordY;

        public static Square[,] arrayOfSquares = new Square[10, 10];
        public static Square[,] arrayOfSq = new Square[10, 10];
        public Ocean(string name)
        {
            if (name != null) Name = name;

            for (CoordX = 0; CoordX < 10; CoordX++)
            {
                for (CoordY = 0; CoordY < 10; CoordY++)
                {
                    arrayOfSquares[CoordX, CoordY] = new Square(CoordX, CoordY);
                }
            }
        }

        //Ocean ocean = new Ocean("XD");
        public static void PrintBoard()
        {
            //Square square = new Square(CoordX, CoordY);

            //Console.WriteLine(ocean.Name);
            Console.WriteLine("   A B C D E F G H I J");
            for (CoordY = 0; CoordY < 10; CoordY++)
            {
                Console.Write(CoordY + 1);
                if (CoordY != 9)
                {
                    Console.Write(" ");
                }

                for (CoordX = 0; CoordX < 10; CoordX++)
                {

                    Console.Write(" " + arrayOfSquares[CoordX, CoordY].Sign);

                }
                Console.WriteLine();
            }

            //Console.WriteLine(square.Sign);
        }

    }
}
//{
//    public class Ocean
//    {
//        private string Name;
//        private static int CoordX;
//        private static int CoordY;
//        public static Square[,] arrayOfSquares = new Square[10, 10];


//        public Ocean(string name)
//        {
//            if (name != null) Name = name;

//            for (CoordX = 0; CoordX < 10; CoordX++)
//            for (CoordY = 0; CoordY < 10; CoordY++)
//                arrayOfSquares[CoordX, CoordY] = new Square(CoordX, CoordY);
//        }
//        Ocean EnemyBoard = new Ocean("Enemy Board");
//        Ocean MyBoard = new Ocean("My Board");


//        public static void PrintBoard()
//        {
//            Ocean ocean = new Ocean("Board");
//            Console.WriteLine(ocean.Name);
//            Console.WriteLine("  A  B  C  D  E  F  G  H  I  J ");
//            for (CoordY = 0; CoordY < 10; CoordY++)
//            {
//                Console.Write(CoordY + 1);

//                if (CoordY != 9) Console.Write(" ");

//                for (CoordX = 0; CoordX < 10; CoordX++)
//                {
//                    Console.Write(" " + arrayOfSquares[CoordX, CoordY].Sign);
//                }
//                Console.WriteLine();
//            }

//            //Console.WriteLine(square.Sign);
//        }
//        //
//        // public static string UpperRow(Ocean ocean)
//        // {
//        //     ocean = new Ocean("Board");
//        //     var firstRow = "   A  B  C  D  E  F  G  H  I  J ";
//        //
//        //     return firstRow + Body();
//        // }
//        //
//        // private static string Body()
//        // {
//        //     for (CoordY = 0; CoordY < 10; CoordY++)
//        //     {
//        //         Console.Write("    " + CoordY + 1);
//        //         
//        //         for (CoordX = 0; CoordX < 10; CoordX++)
//        //         {
//        //             if (CoordY != 9)
//        //             {
//        //                 Console.WriteLine("    ");
//        //             }
//        //
//        //             Console.Write(" " + arrayOfSquares[CoordX, CoordY].Sign);
//        //         }
//        //     }
//        //
//        //     return Body();
//        // }
//        //
//        // public bool IsItBorder()
//        // {
//        //     if (Ocean.arrayOfSquares != null && (Ocean.arrayOfSquares(CoordX) < 0 && Ocean.arrayOfSquares(CoordX) > 10)
//        //     {
//        //         
//        //     }
//        //         return false;
//        // }

//    }


//}