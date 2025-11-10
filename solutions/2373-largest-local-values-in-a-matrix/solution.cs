public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int n = grid.Length;
        int[][] res = new int[n -2 ][];

        for(int i = 0; i<n-2;i++){

            res[i] = new int[n-2];

            for(int j = 0; j < n - 2; j++){

                int maxValue = Math.Max(  Math.Max(grid[i][j], grid[i][j+1]),Math.Max(grid[i][j+2], grid[i+1][j]));
                
                maxValue = Math.Max(maxValue, Math.Max(grid[i+1][j+1], grid[i+1][j+2]));
                maxValue = Math.Max(maxValue, Math.Max(grid[i+2][j], grid[i+2][j+1]));
                maxValue = Math.Max(maxValue, grid[i+2][j+2]);

                res[i][j] = maxValue;
            }
        }
        return res;
    }
}