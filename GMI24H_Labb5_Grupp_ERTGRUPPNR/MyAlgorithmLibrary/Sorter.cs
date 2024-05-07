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
        // BubbleSort (Stephens, 2019)
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

        // HeapSort (GeeksforGeeks, 2024a)
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

        // InsertionSort (GeeksforGeeks, 2024b)
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

        // QuickSort (GeeksforGeeks, 2024c)
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

        // SelectionSort (Stephens, 2019)
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
// References:
// GeeksforGeeks. (2024a, 29 Mars 2024). Heap Sort – Data Structures and Algorithms Tutorials. Retrieved 2 Maj from https://www.geeksforgeeks.org/heap-sort/
// GeeksforGeeks. (2024b, 27 April 2024). Insertion Sort – Data Structure and Algorithm Tutorials. Retrieved 2 Maj from https://www.geeksforgeeks.org/insertion-sort/
// GeeksforGeeks. (2024c, 9 April 2024). QuickSort – Data Structure and Algorithm Tutorials. Retrieved 2 Maj from https://www.geeksforgeeks.org/quick-sort/
// Stephens, R. (2019). Sorting. In Essential Algorithms:  A Practical Approach to Computer Algorithms Using Python® and C# (pp. 167-200). https://doi.org/https://doi.org/10.1002/9781119575955.ch6 
