using System;
using System.Collections.Generic;

public class Solution
{
    public bool AreOccurrencesEqual(string s)
    {

        Dictionary<char, int> charCount = new Dictionary<char, int>();
  
        foreach (var ch in s)
        {
            if (charCount.ContainsKey(ch))
            {
                charCount[ch]++;
            }
            else
            {
                charCount[ch] = 1;
            }
        }

        int firstCount = charCount.Values.First();

        foreach (var count in charCount.Values)
        {
            if (count != firstCount)
            {
                return false;  
            }
        }

        return true;  
    }
}
