using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest_1.Solutions
{
    internal class Solution_4
    {
        // 4. 사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 Solution 을 완성하라.

        public int Solution(int num)
        {
            int answer = 0;
            while (num > 0)
            {
                answer += num % 10;
                num /= 10;
            }
            return answer;
        }
    }
}
