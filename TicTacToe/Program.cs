using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] playField =
            {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}
            };
            bool inputCorrect = true;

            WriteGrid(playField);

            Console.WriteLine();
            int player = 2;
            string input;

            do
            {
                if (player == 2)
                    player = 1;
                else
                    player = 2;

                do
                {
                    Console.Write($"Player {player}: Please choose your field! ");
                    input = Console.ReadLine();
                } while (!inputCorrect);

                switch (player)
                {
                    case 1:
                        XorO(player, input, playField);
                        Console.Clear();
                        WriteGrid(playField);
                        break;
                    case 2:
                        XorO(player, input, playField);
                        Console.Clear();
                        WriteGrid(playField);
                        break;
                }
            } while (true);

            
            Console.Read();
        }
        public static void WriteGrid(string[,] numbers)
        {
            
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {numbers[0,0]}  |  {numbers[0,1]}  |  {numbers[0,2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {numbers[1,0]}  |  {numbers[1,1]}  |  {numbers[1,2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {numbers[2,0]}  |  {numbers[2,1]}  |  {numbers[2,2]}  ");
            Console.WriteLine("     |     |     ");
        }
        public static void XorO(int player, string input, string[,] numbers)
        {
            string playerSign = "";

            if (player == 1)
                playerSign = "X";
            else
                playerSign = "O";

            switch (input)
            {
                case "1":
                    numbers[0, 0] = playerSign;
                    break;
                case "2":
                    numbers[0, 1] = playerSign;
                    break;
                case "3":
                    numbers[0, 2] = playerSign;
                    break;
                case "4":
                    numbers[1, 0] = playerSign;
                    break;
                case "5":
                    numbers[1, 1] = playerSign;
                    break;
                case "6":
                    numbers[1, 2] = playerSign;
                    break;
                case "7":
                    numbers[2, 0] = playerSign;
                    break;
                case "8":
                    numbers[2, 1] = playerSign;
                    break;
                case "9":
                    numbers[2, 2] = playerSign;
                    break;
            }
        }
    }
}
