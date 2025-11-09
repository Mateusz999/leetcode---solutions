using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string KthDistinct(string[] arr, int k)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();
        foreach (var s in arr)
        {
            if (freq.ContainsKey(s))
                freq[s]++;
            else
                freq[s] = 1;
        }

        int count = 0;
        foreach (var s in arr)
        {
            if (freq[s] == 1)
            {
                count++;
                if (count == k)
                    return s;
            }
        }

        return "";
    }
}
