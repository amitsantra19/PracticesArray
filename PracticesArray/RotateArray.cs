using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticesArray
{
    public class RotateArray
    {
        public static int FindGCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return FindGCD(b, a % b);
        }
        
        public static void RotateArrayByGcd(int[] arr, int n, int d)
        {
            int i, j, k, temp;
            int gcd = FindGCD(n,d);
            for (i = 0; i < gcd; i++)
            {
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k>=n)
                    {
                        k = k - n;
                    }
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }

        }

        public static void RotateByBlock(int[] arr, int d)
        {
            //int n = arr.Length;
            //for (int i = 0; i < n; i++)
            //{
            //    if (d>n)
            //    {
            //        d %= n;
            //        arr[i] = arr[(i + d) % n];
            //    }

            //    Console.Write(arr[i] + " ");
            //}
            int[] temp = new int[d];
            int[] result = new int[arr.Length];
            for (int i = 0; i < d; i++)
            {
                temp[i] = arr[i];
            }
            for (int i = 0; i < arr.Length - d; i++)
            {
                result[i] = arr[i + d];
                Console.Write(result[i] + " ");
            }
            for (int i = 0; i < temp.Length; i++)
            {
                result[arr.Length - d + i] = temp[i];
                Console.Write(result[arr.Length - d + i] + " ");
            }
            //return result;


        }


        public static void LeftRotatebyOne(int[] arr)
        {
            int temp = arr[0];
            int i;
            for (i = 0; i < arr.Length -1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[i] = temp;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " "); 
            }
        }
    }
}
