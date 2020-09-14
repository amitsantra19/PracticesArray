using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesArray
{
    public class RemoveDuplicatesFromArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            //int len = nums.Length;
            //int i;
            //List<int> arr = new List<int>();
            //for (i = 0; i < len - 1; i++)
            //{
            //    if (nums[i] != nums[i + 1])
            //    {
            //        arr.Add(nums[i]);
            //    }
            //}
            //arr.Add(nums[len - 1]);
            //return arr.Count();
            int len = nums.Length;
            int i, j = 0;
            int[] arr = new int[len];
            for (i = 0; i < len - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    arr[j++] = nums[i];
                    //j++;
                }
            }
            arr[j++] = nums[len - 1];

            for (int k = 0; k < j; k++)
                nums[k] = arr[k];

            return j;
        }
    }
}
