using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Library;


namespace Task2.Test
{
    [TestClass]
    public class JaggetSortTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullJuggedTest()
        {
            int[][] jaggedArray = null;

            JaggedSort.SortArr(jaggedArray, new MaxValueAbsFinder());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullJuggedArrTest()
        {
            int[][] jaggedArray = new int[3][];

            JaggedSort.SortArr(jaggedArray, new MaxValueAbsFinder());
        }
        [TestMethod]
        public void SortByMaxElAscTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            JaggedSort.SortArr(jaggedArray, new MaxValueAbsFinder());

            Assert.AreEqual(jaggedArray[0][0], 3);
            Assert.AreEqual(jaggedArray[1][0], 4);
            Assert.AreEqual(jaggedArray[2][0], -64);
        }
        [TestMethod]
        public void SortByMaxElDescTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            JaggedSort.SortArr(jaggedArray, new MaxValueAbsFinder(), false);

            Assert.AreEqual(jaggedArray[2][0], 3);
            Assert.AreEqual(jaggedArray[1][0], 4);
            Assert.AreEqual(jaggedArray[0][0], -64);
        }
        [TestMethod]
        public void SortByMinElAscTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            JaggedSort.SortArr(jaggedArray, new MinValueAbsFinder());

            Assert.AreEqual(jaggedArray[0][0], 3);
            Assert.AreEqual(jaggedArray[1][0], 4);
            Assert.AreEqual(jaggedArray[2][0], -64);
        }
        [TestMethod]
        public void SortByMinElDescTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            JaggedSort.SortArr(jaggedArray, new MinValueAbsFinder(), false);

            Assert.AreEqual(jaggedArray[2][0], 3);
            Assert.AreEqual(jaggedArray[1][0], 4);
            Assert.AreEqual(jaggedArray[0][0], -64);
        }
        [TestMethod]
        public void SortBySumAscTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            JaggedSort.SortArr(jaggedArray, new SumValueFinder());

            Assert.AreEqual(jaggedArray[0][0], -64);
            Assert.AreEqual(jaggedArray[1][0], 3);
            Assert.AreEqual(jaggedArray[2][0], 4);
        }
        [TestMethod]
        public void SortBySumDescTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            JaggedSort.SortArr(jaggedArray, new SumValueFinder(), false);

            Assert.AreEqual(jaggedArray[2][0], -64);
            Assert.AreEqual(jaggedArray[1][0], 3);
            Assert.AreEqual(jaggedArray[0][0], 4);
        }
        [TestMethod]
        public void SortByMultAscTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            JaggedSort.SortArr(jaggedArray, new MultValueFinder());

            Assert.AreEqual(jaggedArray[0][0], -64);
            Assert.AreEqual(jaggedArray[1][0], 3);
            Assert.AreEqual(jaggedArray[2][0], 4);
        }
        [TestMethod]
        public void SortByMultDescTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 4, 42 };
            jaggedArray[1] = new int[] { -64, 6 };
            jaggedArray[2] = new int[] { 3 };

            JaggedSort.SortArr(jaggedArray, new MultValueFinder(), false);

            Assert.AreEqual(jaggedArray[2][0], -64);
            Assert.AreEqual(jaggedArray[1][0], 3);
            Assert.AreEqual(jaggedArray[0][0], 4);
        }
    }
}
