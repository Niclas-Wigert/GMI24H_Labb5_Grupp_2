using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GMI24H_Labb5_Grupp_ERTGRUPPNR.MyAlgorithmLibrary
{
    /// <summary>
    /// This class is used to implement the algorithms defined in the ISorter interface.
    /// When you have implemented the algorithms, you should be able to test them by instantiating
    /// a Sorter object and call the methods.
    /// </summary>
    public class Sorter : ISorter
    {
        public void BubbleSort(int[] arr)
        {
            bool not_sorted = true;
            while (not_sorted)
            {
                not_sorted = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        not_sorted = true;
                    }
                }
            }
        }


        // Reference for HeapSort https://www.geeksforgeeks.org/heap-sort/
        public void HeapSort(int[] arr)
        {
            int heapSize = arr.Length;

            for (int i = heapSize / 2 - 1; i >= 0; i--)
            {
                MakeHeap(arr, heapSize, i);
            }

            for (int i = heapSize - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                MakeHeap(arr, i, 0);
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
        private void MakeHeap(int[] arr, int heapSize, int i)
        {
            int largestIndex = i;

            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < heapSize && arr[left] > arr[largestIndex])
            {
                largestIndex = left;
            }

            if (right < heapSize && arr[right] > arr[largestIndex])
            {
                largestIndex = right;
            }

            if (largestIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[largestIndex];
                arr[largestIndex] = temp;

                MakeHeap(arr, heapSize, largestIndex);
            }
        }

        public void InsertionSort(int[] arr)
        {       
            for (int i = 1; i < arr.Length; i++)
            {
                int peek = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > peek)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = peek;
            }
        }

        public void QuickSort(int[] arr, int low, int high)
        {
            //Replace the following code snippet with your implementation
            throw new NotImplementedException();
        }

        public void SelectionSort(int[] arr)
        {
            //Replace the following code snippet with your implementation
            throw new NotImplementedException();
        }
        private void PrintSumShit(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
