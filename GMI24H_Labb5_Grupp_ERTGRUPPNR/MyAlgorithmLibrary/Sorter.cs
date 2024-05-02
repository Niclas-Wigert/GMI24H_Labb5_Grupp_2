using System;
using System.Collections.Generic;
using System.Linq;
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
        //Bubblesort(Data: values[])
        //// Repeat until the array is sorted.
        //Boolean: not_sorted = True
            //While(not_sorted)
            //// Assume we won't find a pair to swap.
            //not_sorted = False
            //// Search the array for adjacent items that are out of order.
                //For i = 0 To<length of values> - 1
                //// See if items i and i - 1 are out of order.
                //If(values[i] < values[i - 1]) Then
                //// Swap them.
                //Data: temp = values[i]
                //values[i] = values[i - 1]
                //values[i - 1] = temp
                //// The array isn't sorted after all.
                //not_sorted = True
            //End If
        //Next i
        //End While
        //End Bubblesort
        public void BubbleSort(int[] arr)
        {
            bool not_sorted = true;
            while (not_sorted)
            {
                not_sorted = false;
                for(int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] > arr[i+1]) 
                    {
                        int temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = temp;
                        not_sorted=true;
                    }
                }
            }
        }

        public void HeapSort(int[] arr)
        {
            arr = MakeHeap(arr);
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[0] + "," + arr[i]);
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                MakeHeap(arr);
                Console.WriteLine(arr[0]+","+arr[i]);
                Console.WriteLine();
            }
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
        }
        private int[] MakeHeap(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index = i;

                while (index != 0)
                {
                    int parent = (index - 1) / 2;
                    if (arr[index] <= arr[parent])
                    {
                        break;
                    }

                    int temp = arr[index];
                    arr[index] = arr[parent];
                    arr[parent] = temp;

                    index = parent;
                }
            }
            return arr;
        }

        public void InsertionSort(int[] arr)
        {
            //Replace the following code snippet with your implementation
            throw new NotImplementedException();
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
    }
}
