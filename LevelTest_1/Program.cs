using LevelTest_1.Solutions;

namespace LevelTest_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 문자열 속에 문자 찾기
            Solution_1 solution_1 = new Solution_1();
            Console.WriteLine(solution_1.Solution("pineapple is yummy", "apple"));
            
            // 2. 문자열을 입력받으면 단어의 갯수를 출력하기
            Solution_2 solution_2 = new Solution_2();
            Console.WriteLine(solution_2.Solution("안녕하세요. 나는 서울에 사는 홍길동이라고 합니다."));

            // 3. 주어진 숫자가 소수인지 판별하는 solution을 완성하라.
            Solution_3 solution_3 = new Solution_3();
            Console.WriteLine(solution_3.Solution(5));

            // 4. 사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 Solution 을 완성하라.
            Solution_4 solution_4 = new Solution_4();
            Console.WriteLine(solution_4.Solution(1234)); 



        }
    }
}