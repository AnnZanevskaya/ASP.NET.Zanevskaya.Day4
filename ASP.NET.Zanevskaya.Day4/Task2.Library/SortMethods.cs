using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
        public class MaxValueFinder : ICompare
        {
            public bool Compare(int[] firstA, int[] secondA)
            {
                return (MaxEl(firstA) < MaxEl(secondA));
            }
            private static int MaxEl(int[] arr)
            {
                int maxEl = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    maxEl = Math.Max(maxEl, Math.Abs(arr[i]));
                }
                return maxEl;
            }
        }
        public class SumValueFinder : ICompare
        {
            public bool Compare(int[] firstA, int[] secondA)
            {
                return (SumValue(firstA) < SumValue(secondA));
            }
            private static int SumValue(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        } 
}
