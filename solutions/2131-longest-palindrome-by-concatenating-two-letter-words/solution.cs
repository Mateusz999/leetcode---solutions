public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        var result = 0;
        var freq = new int[26, 26];

        foreach (var word in words)
        {
            var left = word[0] - 'a';
            var right = word[1] - 'a';

            if (freq[right, left] != 0)
            {
                freq[right, left]--;
                result += 4;
            }
            else
            {
                freq[left, right]++;
            }
        }

        if (result % 2 == 0)
        {
            for (var i = 0; i < 26; i++)
            {
                if (freq[i, i] != 0)
                    return result + 2;
            }
        }

        return result;
    }
}