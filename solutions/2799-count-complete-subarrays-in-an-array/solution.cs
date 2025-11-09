using System;
using System.Collections.Generic;

public class Solution
{
    public int CountCompleteSubarrays(int[] nums)
    {
        int n = nums.Length;

        // Step 1: Get the number of distinct elements in the array
        HashSet<int> uniqueElements = new HashSet<int>(nums);
        int totalDistinct = uniqueElements.Count;

        int count = 0;

        // Step 2: Sliding window
        for (int i = 0; i < n; i++)
        {
            HashSet<int> windowSet = new HashSet<int>();
            for (int j = i; j < n; j++)
            {
                windowSet.Add(nums[j]);
                if (windowSet.Count == totalDistinct)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
