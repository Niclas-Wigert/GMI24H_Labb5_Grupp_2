using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMI24H_Labb5_Grupp_ERTGRUPPNR.MyAlgorithmLibrary
{
    /// <summary>
    /// This class is used to implement the algorithms defined in the ISearcher interface.
    /// When you have implemented the algorithms, you should be able to test them by instantiating
    /// a Searcher object and call the methods.
    /// </summary>
    public class Searcher : ISearcher
    {
        public int BinarySearch(int[] array, int target)
        {
            int min = 0;
            int max = array.Length-1;
            while (min <= max)
            {
                int mid = (min+max)/2;
                if (target < array[mid])
                {
                    max = mid - 1;
                }
                else if (target > array[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public int ExponentialSearch(int[] array, int target)
        {
            //Replace the following code snippet with your implementation
            throw new NotImplementedException();
        }

        public int InterpolationSearch(int[] array, int target)
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = min + ((target - array[min]) * (max - min) / (array[max] - array[min]));
                //int mid = min + (((max - min) / (array[max] - array[min])) * (target - array[min]));
                if (array[mid] == target)
                {
                    return mid;
                }
                else if (target < array[mid])
                {
                    max = mid - 1;
                }
                else if (target > array[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }

        public int JumpSearch(int[] array, int target)
        {
            //Replace the following code snippet with your implementation
            throw new NotImplementedException();
        }

        public int LinearSearch(int[] array, int target)
        {
            for(int i = 0;i < array.Length ; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
                if (array[i] > target)
                {
                    return -1;
                }
            }
            return -1;
        }
    }
}
