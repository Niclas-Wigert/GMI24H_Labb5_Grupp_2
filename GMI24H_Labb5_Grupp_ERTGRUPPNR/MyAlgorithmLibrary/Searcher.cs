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
        // BinarySearch (Stephens, 2019)
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

        // InterpolationSearch, (GeeksforGeeks, 2023; Stephens, 2019)
        public int InterpolationSearch(int[] array, int target)
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max && target >= array[min] && target <= array[max])
            {
                if (min == max)
                {
                    if (array[min] == target)
                    {
                        return min;
                    }
                    return -1;
                }
                int mid = min + ((target - array[min]) * (max - min) / (array[max] - array[min]));
                if (array[mid] == target)
                {
                    return mid;
                }
                else if (target > array[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }

        public int JumpSearch(int[] array, int target)
        {
            //Replace the following code snippet with your implementation
            throw new NotImplementedException();
        }

        // LinearSearch (Stephens, 2019)
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
// References:
// GeeksforGeeks. (2023, 15 Maj 2023). Interpolation Search. Retrieved 7 Maj from https://www.geeksforgeeks.org/interpolation-search/
// Stephens, R. (2019). Searching. In Essential Algorithms: A Practical Approach to Computer Algorithms Using Python® and C# (pp. 201-208). https://doi.org/https://doi.org/10.1002/9781119575955.ch7 
