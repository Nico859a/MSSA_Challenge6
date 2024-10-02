using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengelab6
{
    internal class FindOnce
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1 };
            int singleNumber = SingleNumber(nums);

            Console.WriteLine($"The single number is: {singleNumber}");
        }

        public static int SingleNumber(int[] nums)
        {

            int j = 0;
            if (nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return nums[0];
            }
            else
            {
                for (int i = 1; i < nums.Length; i++)
                {

                    if (nums[j] == nums[i])
                    {
                        int temp = nums[j + 1];
                        nums[j + 1] = nums[i];
                        nums[i] = temp;
                        j = j + 2;
                        i = j;
                    }
                }
            }
            return nums[j];
        }
    }
}
