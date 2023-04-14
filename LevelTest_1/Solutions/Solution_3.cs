using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest_1.Solutions
{
    internal class Solution_3
    {
        // 3. 주어진 숫자가 소수인지 판별하는 solution을 완성하라.
        public bool Solution(int n)
        {
            for(int i = 2; i < n/2; i++)
            {
                if (n % i == 0) { return false; }
            }
            return true;
        }
    }
}
