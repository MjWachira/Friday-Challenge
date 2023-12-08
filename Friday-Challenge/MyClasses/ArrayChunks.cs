using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Challenge.MyClasses
{
    public class ArrayChunks
    {
        public void ArrayChunk(int[] source, int chunkSize)
        {
            // Given an array and chunk size, divide the array into subarrays
            // where each subarray has a length equal to the chunk size.
            // E.g., [1,2,3,4,5,6,7,8,9,10,11,12,4,4], 3
            // Result: [ [1, 2, 3], [4, 5, 6], [7, 8, 9], [10, 11, 12], [4, 4] ]

            int[][] result = source
                .Select((value, index) => new { value, index })
                .GroupBy(x => x.index / chunkSize)
                .Select(group => group.Select(x => x.value).ToArray())
                .ToArray();

            // Display the result
            foreach (var subarray in result)
            {
                Console.WriteLine("[ " + string.Join(", ", subarray) + " ]");
            }
        }
    
    }
}
