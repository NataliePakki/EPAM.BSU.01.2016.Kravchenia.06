using System;
using System.Collections.Generic;

namespace Task2 {
    public static class SortJuggedArrayInterface{
        public static void BubbleSort(int[][] array, IComparer<int[]> comparer){
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++){
                    if (comparer.Compare(array[j], array[j + 1]) < 0){
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
        }
        public static void BubbleSort(int[][] array, Comparison<int[]> comp){
            BubbleSort(array, new Adapter(comp));
        }

        private class Adapter : IComparer<int[]> {
            private Comparison<int[]> comp;
            public Adapter(Comparison<int[]> comp){
                if (comp == null)
                    throw new ArgumentNullException($"{nameof(comp)} is null.");
                this.comp = comp;
            }

            public int Compare(int[] arr1, int[] arr2) {
                return comp(arr1, arr2);
            }
        }
        
        private static void Swap(ref int[] array1, ref int[] array2){
            int[] temp = array1;
            array1 = array2;
            array2 = temp;
        }
    }

}
