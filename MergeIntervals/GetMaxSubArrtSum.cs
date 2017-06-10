using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeIntervals
{
    public class GetMaxSubArrtSum
    {
        public static int GetMaxSubArrySum(int[] array)
        {
            int size = array.Length;
            if (array.Length == 0)
                throw new Exception("empty array");
            int curr = 0;
            int sum = 0;
            int max = 0;
            while (curr < size)
            {
                sum += array[curr++];
                if (sum > max)
                    max = sum;
                else if (sum < 0)
                    sum = 0;
            }
            return max;
        }
    }
}
