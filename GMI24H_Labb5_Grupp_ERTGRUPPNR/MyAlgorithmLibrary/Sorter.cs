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
        // BubbleSort, Reference: Essential Algorithms
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
                        Swap(arr, i, i + 1);
                        not_sorted = true;
                    }
                }
            }
        }

        // HeapSort, Reference: https://www.geeksforgeeks.org/heap-sort/
        public void HeapSort(int[] arr)
        {
            int heapSize = arr.Length;
            
            for (int i = heapSize / 2 - 1; i >= 0; i--)
            {
                MakeHeap(arr, heapSize, i);
            }

            for (int i = heapSize - 1; i > 0; i--)
            {
                Swap(arr, 0, i);
                MakeHeap(arr, i, 0);                
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
                Swap(arr, i, largestIndex);
                MakeHeap(arr, heapSize, largestIndex);
            }
        }

        // InsertionSort, Reference: https://www.geeksforgeeks.org/insertion-sort/
        public void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int peek = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > peek)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = peek;
            }
        }

        // QuickSort, Reference: https://www.geeksforgeeks.org/quick-sort/
        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            } 
        }

        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        // SelectionSort, Reference: Essential Algorithms
        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }

        // Method for when we tried them
        public void PrintSumShit(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Method for Swap
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
