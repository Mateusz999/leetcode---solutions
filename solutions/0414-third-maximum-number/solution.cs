using System;
using System.Collections.Generic;

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        // SortedSet in descending order
        SortedSet<int> top3 = new SortedSet<int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (int num in nums)
        {
            top3.Add(num);
            if (top3.Count > 3)
            {
                top3.Remove(top3.Max); // Remove smallest of the top 4
            }
        }

        // If we have at least 3 elements, return the 3rd max
        if (top3.Count == 3)
        {
            return top3.Max;
        }

        // Else return the maximum (first element in descending order)
        return top3.Min; // top3.Min == highest if fewer than 3
    }
}
