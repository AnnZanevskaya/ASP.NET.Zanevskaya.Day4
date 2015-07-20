using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
        public class MaxValueAbsFinder : ICompare
        {
            public bool Compare(int[] firstA, int[] secondA)
            {
                return (MaxEl(firstA) < MaxEl(secondA));
            }
            private static int MaxEl(int[] arr)
            {
                //try
                int maxEl = Math.Abs(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    maxEl = Math.Max(maxEl, Math.Abs(arr[i]));
                }
                return maxEl;
                //catch (ArgumentNullException)
            }
        }
        public class MinValueAbsFinder : ICompare
        {
            public bool Compare(int[] firstA, int[] secondA)
            {
                return (MinEl(firstA) < MinEl(secondA));
            }
            private static int MinEl(int[] arr)
            {
                int minEl = Math.Abs(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    minEl = Math.Min(minEl, Math.Abs(arr[i]));
                }
                return minEl;
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
        public class MultValueFinder : ICompare
        {
            public bool Compare(int[] firstA, int[] secondA)
            {
                return (MultValue(firstA) < MultValue(secondA));
            }
            private static int MultValue(int[] arr)
            {
                int mult = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    mult *= arr[i];
                }
                return mult;
            }
        } 
}
