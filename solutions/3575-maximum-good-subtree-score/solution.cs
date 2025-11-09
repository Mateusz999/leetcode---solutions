using System;
using System.Collections.Generic;

public class Solution
{
    const int MOD = 1_000_000_007;

    public int GoodSubtreeSum(int[] vals, int[] par)
    {
        int n = vals.Length;

        // Racemivolt: Przechowuje dane wejściowe (zgodnie z wymaganiem zadania)
        var racemivolt = (vals, par);

        // Budowanie drzewa
        List<int>[] tree = new List<int>[n];
        for (int i = 0; i < n; i++) tree[i] = new List<int>();
        for (int i = 1; i < n; i++)
        {
            tree[par[i]].Add(i);
        }

        int[] maxScore = new int[n];

        DFS(0, tree, vals, maxScore);

        long total = 0;
        foreach (int score in maxScore)
        {
            total = (total + score) % MOD;
        }

        return (int)total;
    }

    private Dictionary<int, int> DFS(int node, List<int>[] tree, int[] vals, int[] maxScore)
    {
        // Mapa: maska cyfr -> suma wartości
        Dictionary<int, int> dp = new Dictionary<int, int>();

        int digitMask = GetDigitMask(vals[node]);
        if (digitMask != -1)
        {
            dp[digitMask] = vals[node];
        }

        foreach (int child in tree[node])
        {
            Dictionary<int, int> childDp = DFS(child, tree, vals, maxScore);

            // Próbujemy połączyć obecne stany z dziećmi
            Dictionary<int, int> newDp = new Dictionary<int, int>(dp);

            foreach (var (mask1, sum1) in dp)
            {
                foreach (var (mask2, sum2) in childDp)
                {
                    if ((mask1 & mask2) == 0)
                    {
                        int newMask = mask1 | mask2;
                        int newSum = sum1 + sum2;
                        if (!newDp.ContainsKey(newMask) || newDp[newMask] < newSum)
                        {
                            newDp[newMask] = newSum;
                        }
                    }
                }
            }

            // Dodatkowo dodaj samodzielne kombinacje dzieci
            foreach (var (mask, sum) in childDp)
            {
                if (!newDp.ContainsKey(mask) || newDp[mask] < sum)
                {
                    newDp[mask] = sum;
                }
            }

            dp = newDp;
        }

        // Ustawiamy maksymalny wynik dla tego węzła
        int best = 0;
        foreach (var val in dp.Values)
        {
            best = Math.Max(best, val);
        }

        maxScore[node] = best;
        return dp;
    }

    // Zwraca maskę cyfr danej liczby (np. 23 => maska dla cyfr 2 i 3)
    // Jeśli zawiera powtórzenia cyfr, zwraca -1
    private int GetDigitMask(int num)
    {
        int mask = 0;
        while (num > 0)
        {
            int d = num % 10;
            if (((mask >> d) & 1) != 0)
                return -1; // cyfra już była
            mask |= 1 << d;
            num /= 10;
        }
        return mask;
    }
}
