public class Solution {
    public int[][] OnesMinusZeros(int[][] grid)
    {
        int n = grid.Length;
        int m = grid[0].Length;
        int[] col = new int[m];
        int[] row = new int[n];
        for (int i = 0;i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                row[i] += (grid[i][j] == 1) ? 1 : -1;
                col[j] += (grid[i][j] == 1) ? 1 : -1;
            }
        }
        int[][] jaggedArray = new int[n][];

        for (int i = 0; i < n; i++)
        {
            jaggedArray[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                jaggedArray[i][j] = col[j] + row[i];
            }
        }
        return jaggedArray;
    }
}