using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Task2.Tests {
    [TestFixture]
    public class SortJuggedArrayDelegateTests{
        readonly int[][] _array = { new[] { 2, 3, 4 }, new[] { 3, -454, 67, 7 }, new[] { 1, 2, 3, 0, 4 } };
        private class ComparerMaxElement : IComparer<int[]>{
            public int Compare(int[] arr1, int[] arr2){
                if (arr1 == null)
                    return 1;
                if (arr2 == null)
                    return -1;
                return arr1.Max(x => Math.Abs(x)).CompareTo(arr2.Max(x => Math.Abs(x)));
            }
        }

        [Test]
        public void BubbleSortTest_MaxElement() {
            int[][] result = {new[] {3, -454, 67, 7}, new[] {2, 3, 4}, new[] {1, 2, 3, 0, 4}};

            SortJuggedArrayDelegate.BubbleSort(_array, new ComparerMaxElement());

            Assert.AreEqual(_array, result);
        }
    }
}
