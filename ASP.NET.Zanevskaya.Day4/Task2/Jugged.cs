using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Library;

namespace Task2
{
    class Jugged
    {
        static void Main()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 77, 5 };
            jaggedArray[1] = new int[] { 6, 1 };
            jaggedArray[2] = new int[] { 19, 1 };

            JaggedSort.SortArr(jaggedArray, new SumValueFinder());
            ShowArrow(jaggedArray);
        }
        public static void ShowArrow(int[][] jagged)
        {
            int count = 0;
            foreach (int[] array in jagged)
            {
                Console.WriteLine("Mass {0}", count + 1);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(" elements {0}", jagged[count][i]);
                }
                count++;
            }
        }
    }
}
