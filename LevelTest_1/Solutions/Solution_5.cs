using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest_1.Solutions
{
    internal class Solution_5
    {
        // 5. k개의 정렬된 배열에서 공통항목을 찾는 Solution을 완성하라.단, 중복은 허용하지 않는다..

        public int[] Solution(params int[][] arr)
        {
            List<int> list = new List<int>();

            for(int i = 0; i < arr[0].Length; i++)
            {
                bool containCheck = false;
                for(int j = 1; j < arr.GetLength(0); j++)
                {
                    if (arr[j].Contains(arr[0][i])){ containCheck = true; }
                    else { containCheck = false; }
                }
                if (containCheck)
                {
                    if (list.Contains(arr[0][i]))
                    {
                        continue;
                    }
                    list.Add(arr[0][i]);
                }
            }

            int[] answer = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                answer[i] = list[i];
            }
            return answer;
        }

    }
}
