using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesArray
{
    class Program
    {
        static public void Main()
        {
            int[] ab = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //int[] ab = { 1, 1, 2 };
            int len = RemoveDuplicatesFromArray.RemoveDuplicates(ab);
            int[] arr2 = {5,6,-10,-2,2,3,-9 };
            MaxSumSubArray.FindMaxSumSubArray(arr2);
            int[] temp = { 1,2,3,4,5,6,7,8,9};
            int a = 9, b = 3;
            RotateArray.RotateArrayByGcd(temp, a, b);

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(s[0]);
                int d = Convert.ToInt32(s[1]);
                string[] arr1 = Console.ReadLine().Split();
                int[] arr = Array.ConvertAll(arr1, int.Parse);
                for (int j = 0; j < d; j++)
                {
                    RotateArray.LeftRotatebyOne(arr);
                }
                RotateArray.PrintArray(arr);
            }
            Console.ReadLine();

        }
    }
}
