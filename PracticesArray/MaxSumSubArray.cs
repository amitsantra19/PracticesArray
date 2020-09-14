using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesArray
{
    public class MaxSumSubArray
    {
        public static int FindMaxSumSubArray(int[] arr)
        {
            int result = int.MinValue;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max = max + arr[i];
                
                if (max<0)
                {
                    max = 0;
                }
                else if (result < max)
                {
                    result = max;
                }
            }
            return result;
        }
    }
}
