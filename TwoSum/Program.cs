using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
            Dictionary<int,int> map = new Dictionary<int, int>();
            int[] result = new int[0];
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                int other = target - nums[i];

                if (map.ContainsKey(other))
                {
                    result = new[] { map[other], i};
                    return result;
                }
                map.Add(nums[i], i);
            }
            return result;
        }
    }
}
