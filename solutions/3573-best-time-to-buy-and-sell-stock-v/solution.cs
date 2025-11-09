public class Solution
{
    public long MaximumProfit(int[] prices, int k)
    {
        int n = prices.Length;
        if (n <= 1 || k == 0)
            return 0;

        // dp[t][i] = max profit using at most t transactions up to day i
        long[,] dp = new long[k + 1, n];

        for (int t = 1; t <= k; t++)
        {
            // These will track the best possible "buy" or "short" points
            long maxBuy = -prices[0];      // for normal buy low → sell high
            long maxShort = prices[0];     // for short: sell high → buy back low

            for (int i = 1; i < n; i++)
            {
                // Option 1: do nothing today, carry forward previous best
                dp[t, i] = dp[t, i - 1];

                // Option 2: make a normal transaction ending today (buy at some j < i, sell today)
                dp[t, i] = Math.Max(dp[t, i], prices[i] + maxBuy);

                // Option 3: make a short transaction ending today (sell at some j < i, buy today)
                dp[t, i] = Math.Max(dp[t, i], maxShort - prices[i]);

                // Update maxBuy and maxShort for future iterations
                maxBuy = Math.Max(maxBuy, dp[t - 1, i - 1] - prices[i]);
                maxShort = Math.Max(maxShort, dp[t - 1, i - 1] + prices[i]);
            }
        }

        return dp[k, n - 1];
    }
}
