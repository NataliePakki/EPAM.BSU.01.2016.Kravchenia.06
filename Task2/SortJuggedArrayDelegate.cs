using System;
using System.Collections.Generic;

namespace Task2 {
    public static class SortJuggedArrayDelegate {
        public static void BubbleSort(int[][] array, IComparer<int[]> comparer) {
            BubbleSort(array,comparer.Compare);
        }
        public static void BubbleSort(int[][] array, Comparison<int[]> comp) {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++){
                    if (comp(array[j], array[j + 1]) < 0){
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
        }

        private static void Swap(ref int[] array1, ref int[] array2) {
            int[] temp = array1;
            array1 = array2;
            array2 = temp;
        }
    }
}
