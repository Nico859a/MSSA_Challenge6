using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengelab6._2
{
    internal class MissingNum
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 0, 1 };
            int missingnum = MissingNumber(nums);

            Console.WriteLine($"The missing number is: {missingnum}");

            int[] nums1 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int missingnum1 = MissingNumber(nums1);

            Console.WriteLine($"The missing number is: {missingnum1}");
        }

        public static int MissingNumber(int[] nums)
        {
            int size = nums.Length + 1;
            int[] ints = new int[size];

            for (int i = 0; i < nums.Length; ++i)
            {
                ints[nums[i]] = -1;
            }

            for (int i = 0; i < size; ++i)
            {
                if (ints[i] > -1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
