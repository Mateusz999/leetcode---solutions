using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> zmapowane = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int dopelnienie = target - nums[i];
            
            if (zmapowane.ContainsKey(dopelnienie))
            {
                return new int[] { zmapowane[dopelnienie], i };
            }
            zmapowane[nums[i]] = i;
        }
        return new int[] { };
    }
}