using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
    public static class JaggedSort
    {
        public static void SortArr(int[][] jagged, ICompare method, bool direction = true)
        {
            if (jagged == null) throw new ArgumentNullException("jugged");
            foreach (int[] arr in jagged)
                if (arr == null) throw new ArgumentNullException("null array");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = i + 1; j < jagged.Length; j++)
                {
                    if (method.Compare(jagged[i], jagged[j]) == (!direction))
                    {
                        Swap(ref jagged[i], ref jagged[j]);
                    }
                }
            }
        }
        private static void Swap(ref int[] firstArr, ref int[] secondArr)
        {
            int[] tempArr = firstArr;
            firstArr = secondArr;
            secondArr = tempArr;
        }
    }

}
