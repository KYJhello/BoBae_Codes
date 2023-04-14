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

            // 5. k개의 정렬된 배열에서 공통항목을 찾는 Solution을 완성하라.단, 중복은 허용하지 않는다..
            Solution_5 solution_5 = new Solution_5();
            int[] arr1 = { 1, 5, 5, 10 };
            int[] arr2 = { 3, 4, 5, 5, 10 };
            int[] arr3 = { 5, 5, 10, 20 };
            int[] commonItems = solution_5.Solution(arr1, arr2, arr3);
            foreach(int item in commonItems) Console.Write($"{item}\t");
            Console.WriteLine();

            /* Up & Down 게임 만들기
            * 1. 컴퓨터는 0~999 중에 랜덤한 숫자를 뽑는다.
            * 2. 유저는 10번의 기회가 있다.
            * 3. 플레이어가 수를 입력 하면 컴퓨터는 그 수가 큰지, 작은지, 정답인지 알려준다.
            * 4. 10번의 기회 소진시 게임을 종료할껀지 재시작 할껀지 선택 할수 있다. 
            */
            UpDownGame.UpDownGame.GameStart();


        }
    }
}