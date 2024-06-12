using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    internal class Program
    {
        public static void MoveZeroes(int[] nums)
        {
            int NoZero = 0;
            int i;

            // value is not qual 0 move to the beginining 
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[NoZero++] = nums[i];
                }
            }

            // index i and equal to zero. It moves to last index 
            for ( i = NoZero; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums1);
            Console.WriteLine(string.Join(", ", nums1)); // Output: [1, 3, 12, 0, 0]

            int[] nums2 = { 0 };
            MoveZeroes(nums2);
            Console.WriteLine(string.Join(", ", nums2)); // Output: [0]
            Console.ReadKey();
        }
    }
}
