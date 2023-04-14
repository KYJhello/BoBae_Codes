using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest_1.BingoGame
{
    internal class BingoGame
    {
        static void CreateBoard(List<List<int>> board)
        {
            Random rand = new Random();

            board.Clear();
            List<int> selected = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                board.Add(new List<int>());
                for (int j = 0; j < 5; j++)
                {
                    int temp;
                    do
                    {
                        temp = rand.Next(0, 25);
                    } while (selected.Contains(temp));
                    selected.Add(temp);
                    board[i].Add(temp);

                }
            }
        }

        static void GameRender(List<List<int>> board, int bingoCount)
        {
            Console.Clear();

            Console.WriteLine("============빙고==========");
            Console.WriteLine($"{bingoCount}개 빙고");
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Count; j++)
                {
                    if (board[i][j] == -1)
                    {
                        Console.Write("#\t");
                    }
                    else
                    {
                        Console.Write("{0}\t", board[i][j]);
                    }

                }
                Console.WriteLine();
            }
        }

        static int GameInput()
        {
            int input = -1;
            while (input == -1)
            {
                Console.Write("입력 : ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    input = -1;
                }
                if (input > 24 || input < 0)
                {
                    Console.WriteLine("0부터 24의 수을 입력해주세요!");
                    input = -1;
                }
            }

            return input;
        }
        static void GameUpdate(int input, List<List<int>> board)
        {
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Count; j++)
                {
                    if (board[i][j] == input)
                    {
                        board[i][j] = -1;
                        return;
                    }
                }
            }
        }
        static int BingoCheck(List<List<int>> board)
        {
            int count = 0;
            int bingoCheckRow = 0;
            int bingoCheckColumn = 0;
            int bingoCheckDiagonal1 = 0;
            int bingoCheckDiagonal2 = 0;

            for (int i = 0; i < board.Count; i++)
            {
                bingoCheckDiagonal1 += board[i][i];
                bingoCheckDiagonal2 += board[4 - i][i];
                for (int j = 0; j < board[i].Count; j++)
                {
                    bingoCheckRow += board[i][j];
                    bingoCheckColumn += board[j][i];
                }
                if (bingoCheckRow == -5) { count++; }
                if (bingoCheckColumn == -5) { count++; }
                bingoCheckRow = 0;
                bingoCheckColumn = 0;
            }
            if (bingoCheckDiagonal1 == -5) { count++; }
            if (bingoCheckDiagonal2 == -5) { count++; }

            return count;
        }
        public static void GameStart()
        {
            Console.Title = "Bingo_Game";
            Console.CursorVisible = false;

            List<List<int>> board = new List<List<int>>();
            int bingoCount = 0;
            CreateBoard(board);
            GameRender(board, bingoCount);

            //loop
            while (true)
            {
                //input
                int input = GameInput();
                //update
                GameUpdate(input, board);
                bingoCount = BingoCheck(board);
                //render
                GameRender(board, bingoCount);
                //quitCheck
                if (bingoCount >= 3)
                {
                    Console.WriteLine("{0}빙고 달성!!", bingoCount);
                    break;
                }
            }

            //release
        }
    }
}

