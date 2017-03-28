using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            int[] ans = null;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ans = new[] {i, j};
                        return ans;
                    }
                }
            }
            return ans;
        }
    }
}
