public class Solution
{
    private bool IsPrime(long n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (long i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public long SumOfLargestPrimes(string s)
    {
        HashSet<long> primes = new HashSet<long>();

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string substring = s.Substring(i, j - i);
                
                if (substring.Length > 1 && substring[0] == '0') continue;

                // Parse substring as long
                long num = long.Parse(substring);

                if (IsPrime(num))
                {
                    primes.Add(num);
                }
            }
        }

        List<long> sortedPrimes = primes.ToList();
        sortedPrimes.Sort((a, b) => b.CompareTo(a)); 

        long sum = 0;
        for (int i = 0; i < Math.Min(3, sortedPrimes.Count); i++)
        {
            sum += sortedPrimes[i];
        }

        return sum;
    }
}
