using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest_1.SlideGame
{
    internal class SlideGame
    {
        class Point
        {
            public int x;
            public int y;
        }
        enum Direction
        {
            Up, Down, Left, Right, None
        }
        static Direction GameInput()
        {
            ConsoleKeyInfo info = Console.ReadKey();    // 키로 입력받아 info에 저장
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    return Direction.Up;
                case ConsoleKey.DownArrow:
                    return Direction.Down;
                case ConsoleKey.LeftArrow:
                    return Direction.Left;
                case ConsoleKey.RightArrow:
                    return Direction.Right;
                default:
                    return Direction.None;
            }
        }

        static void CreateBoard(List<List<int>> board, Point point)
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
                    if (temp == 0)
                    {
                        point.x = j;
                        point.y = i;
                    }
                }
            }
        }

        static void GameRender(List<List<int>> board)
        {
            Console.Clear();
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Count; j++)
                {
                    Console.Write("{0}\t", board[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n ← : 왼쪽\t → : 오른쪽\t↑ : 위쪽\t↓ : 아래쪽");
        }
        static void GameUpdate(Direction input, Point point, List<List<int>> board)
        {
            Point prevPoint = new Point();
            prevPoint.x = point.x;
            prevPoint.y = point.y;

            switch (input)
            {
                case Direction.Up:
                    point.y--;
                    break;
                case Direction.Down:
                    point.y++;
                    break;
                case Direction.Left:
                    point.x--;
                    break;
                case Direction.Right:
                    point.x++;
                    break;
                default:
                    break;
            }
            if (point.x >= 0 && point.y >= 0 && point.x < 5 && point.y < 5)
            {
                board[prevPoint.y][prevPoint.x] = board[point.y][point.x];
                board[point.y][point.x] = 0;
            }
            else
            {
                point.x = prevPoint.x;
                point.y = prevPoint.y;
            }
        }
        public static void GameStart()
        {
            Console.Title = "Slide_Puzzle";
            Console.CursorVisible = false;

            List<List<int>> board = new List<List<int>>();
            Point point = new Point();

            CreateBoard(board, point);
            GameRender(board);

            //loop
            while (true)
            {
                //input
                Direction input = GameInput();
                //update
                GameUpdate(input, point, board);
                //render
                GameRender(board);
                //quitCheck
            }

            //release
        }

    }
}
