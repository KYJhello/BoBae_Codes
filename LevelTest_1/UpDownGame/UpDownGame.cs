using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest_1.UpDownGame
{
    internal class UpDownGame
    {
        enum UpDown { UP, DOWN, 정답 }
        static UpDown CheckAnswer(int answer, int input)
        {
            if (answer > input) { return UpDown.UP; }
            else if (answer < input) { return UpDown.DOWN; }
            else { return UpDown.정답; }
        }
        static bool InputCheck(int input)
        {
            if (input >= 0 && input < 1000) return true;
            else return false;
        }
        public static void GameStart()
        {
            Random random = new Random();

            while (true)
            {
                int answer = random.Next(0, 1000);
                //Console.WriteLine(answer);
                Console.WriteLine("빙고 게임 START!!");

                // 최대 10번의 기회 제공
                for (int chance = 1; chance < 11; chance++)
                {
                    Console.Write($"{chance}번째 : ");
                    int input = int.Parse(Console.ReadLine());
                    if (InputCheck(input))
                    {
                        UpDown result = CheckAnswer(answer, input);
                        Console.WriteLine(result);
                        if (result == UpDown.정답) { break; }
                    }
                    else
                    {
                        Console.WriteLine("입력 오류!!");
                        chance--;
                        continue;
                    }
                }

                // 재시작 여부 판정
                Console.WriteLine("재시작: 1, 종료: 0");
                int restart = int.Parse(Console.ReadLine());
                if (restart == 0)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }

                Console.Clear();
            }
        }


    }
}
