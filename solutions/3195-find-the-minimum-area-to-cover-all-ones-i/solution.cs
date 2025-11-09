public class Solution {
    public int MinimumArea(int[][] grid) {
        int rowMin = grid.Length, rowMax = -1;
        int ColMin = grid[0].Length, colMax = -1;

           for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 1) {
                    rowMin = Math.Min(rowMin, i);
                    rowMax = Math.Max(rowMax, i);
                    ColMin = Math.Min(ColMin, j);
                    colMax = Math.Max(colMax, j);
                }
            }
        }

        return (rowMax - rowMin + 1) * (colMax - ColMin + 1);
    }
}