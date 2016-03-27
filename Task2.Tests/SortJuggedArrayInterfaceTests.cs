using System;
using System.Linq;
using NUnit.Framework;

namespace Task2.Tests {
    [TestFixture]
    class SortJuggedArrayInterfaceTests {
        readonly int[][] _array = { new[] { 2, 3, 4 }, new[] { 3, -454, 67, 7 }, new[] { 1, 2, 3, 0, 4 } };
        private int ComparisonMaxElement(int[] arr1, int[] arr2) {
            if (arr1 == null)
                return 1;
            if (arr2 == null)
                return -1;
            return arr1.Max(x => Math.Abs(x)).CompareTo(arr2.Max(x => Math.Abs(x)));
        }
        [Test]
        public void BubbleSortTest_MaxElement() {
            int[][] result = { new[] { 3, -454, 67, 7 }, new[] { 2, 3, 4 }, new[] { 1, 2, 3, 0, 4 } };

            SortJuggedArrayInterface.BubbleSort(_array, ComparisonMaxElement);

            Assert.AreEqual(_array, result);
        }

       
    }
}
