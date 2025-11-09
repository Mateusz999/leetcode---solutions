public class Solution
{
    const int MOD = 1_000_000_007;

    public int[] BaseUnitConversions(int[][] conversions)
    {
        int n = conversions.Length + 1;

        var graph = new Dictionary<int, List<(int, long)>>();

        for (int i = 0; i < n; i++)
            graph[i] = new List<(int, long)>();

        foreach (var conversion in conversions)
        {
            int from = conversion[0];
            int to = conversion[1];
            int factor = conversion[2];

            graph[from].Add((to, factor));
        }

        long[] result = new long[n];
        bool[] visited = new bool[n];

        void DFS(int node, long value)
        {
            visited[node] = true;
            result[node] = value;

            foreach (var (next, factor) in graph[node])
            {
                if (!visited[next])
                {
                    DFS(next, (value * factor) % MOD);
                }
            }
        }

        DFS(0, 1); // Start at unit 0 with value 1

        int[] finalResult = new int[n];
        for (int i = 0; i < n; i++)
            finalResult[i] = (int)result[i];

        return finalResult;
    }
}