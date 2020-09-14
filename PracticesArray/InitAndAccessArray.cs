using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesArray
{
    public class InitAndAccessArray
    {
        //1D array 
        public int[] x = { 1, 2, 5, 6 };
        public char[] name = new char[4] { 'A', 'M', 'I', 'T' };

        public void AccessOneDArray()
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);
            }
            Console.WriteLine();
            foreach (var item in name)
            {
                Console.Write(item);
            }
        }

        public int[,] y = { { 1,2,3},
                            {7,8,9 },
                            {6,5,4 }};

        public int[,] z = new int[2, 4]
        {
            { 3,2,1,4},
            { 6,9,8,7}
        };
        
        public void AccessTwoDArray()
        {
            Console.WriteLine();
            Console.WriteLine("2D Array with equal number of rows and cols");
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    Console.Write(y[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("2D Array where number of rows and cols are not equal");
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Console.Write(z[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        private readonly int[,,] threeD = { { { 1,2},
                                { 4,6} },
                               { {8,9 },
                                 {10,12 } },
                                { {8,7},
                                {45,50} } };

        private readonly int[,,] threeDD =new int[3,2, 3] { { { 1,2,6},
                                { 4,6,8} },
                               { {8,9 ,10},
                                 {10,12,25 } },
                                { {8,7,60},
                                {45,50,20} } };

        public void AccessThreeDArray()
        {
            Console.WriteLine();
            Console.WriteLine("3D Array with equal number of rows and cols");
            for (int i = 0; i < threeD.GetLength(0); i++)
            {
                for (int j = 0; j < threeD.GetLength(1); j++)
                {
                    for (int k = 0; k < threeD.GetLength(2); k++)
                    {
                        Console.Write(threeD[i, j,k] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("3D Array where number of rows and cols are not equal");
            for (int i = 0; i < threeDD.GetLength(0); i++)
            {
                for (int j = 0; j < threeDD.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDD.GetLength(2); k++)
                    {
                        Console.Write(threeDD[i, j, k] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public void Read1DArrayInput(int nums)
        {
            string[] oneDAryS = new string[nums];
            int[] oneDAryI = new int[nums];
            char[] oneDAryC = new char[nums];
            double[] oneDAryD = new double[nums];
            for (int i = 0; i < nums; i++)
            {
                //oneDAryS[i] = Console.ReadLine();
                oneDAryI[i] = Convert.ToInt32(Console.ReadLine());
                //oneDAryD[i] = Convert.ToDouble(Console.ReadLine());
                //oneDAryC[i] = Console.ReadLine()[0]; 
                //oneDAryC[i] = char.TryParse(Console.ReadLine());
                //oneDAryC[i] = Convert.ToChar(Console.ReadLine());

            }
            // take input by space
            //oneDAryI = Array.ConvertAll(Console.ReadLine().Split(' '), ele => Convert.ToInt32(ele));
            //oneDAryC = Array.ConvertAll(Console.ReadLine().Split(' '), ele => Convert.ToChar(ele));
            //oneDAryS = Console.ReadLine().Split(' ');
            Console.WriteLine("Print the input one dimensional Array");
            for (int i = 0; i < nums; i++)
            {
                //Console.WriteLine("String 1D Array");
                //Console.WriteLine(oneDAryS[i]);
                Console.WriteLine("Int 1D Array");
                Console.WriteLine(oneDAryI[i]);
                //Console.WriteLine("Double 1D Array");
                //Console.WriteLine(oneDAryD[i]);
                //Console.WriteLine("Char 1D Array");
                //Console.WriteLine(oneDAryC[i]);

            }
        }


    


    }
}
