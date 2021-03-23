using System;

namespace SelectionSort
{
    class Program
    {
        /// <summary>
        /// The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order)
        /// from unsorted part and putting it at the beginning. 
        /// The algorithm maintains two subarrays in a given array.
        ///     1) The subarray which is already sorted.
        ///     2) Remaining subarray which is unsorted.
        /// In every iteration of selection sort, the minimum element (considering ascending order) from the unsorted subarray is picked and moved 
        /// to the sorted subarray.
        /// </summary>
        public static void selectionSort(int[] array)
        {
            int arr_length = array.Length;
            for (int i = 0; i < arr_length - 1; i++)
            {
                int min_index = i;
                for(int j = i + 1; j < arr_length; j++)
                {
                    if(array[j] < array[min_index])
                        min_index = j;

                    int swap = array[min_index];
                    array[min_index] = array[i];
                    array[i] = swap;
                }
            }
        }

        static void printSortedArray(int[] array)
        {
            for(int i = 0; i < array.Length; ++i)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = {7,2,6,3,12,33,18};
            selectionSort(arr);
            printSortedArray(arr);
        }
    }
}
