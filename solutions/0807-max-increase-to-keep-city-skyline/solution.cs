public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int n  = grid.Length;
        int res = 0;
        int[] MaxRowValue = new int[n];
        int[] MaxColValue = new int[n];
        
        for(int i = 0; i<n;i++){
            for(int j = 0;j<n;j++){
                MaxRowValue[i] = Math.Max(MaxRowValue[i], grid[i][j] );
                MaxColValue[j] = Math.Max(MaxColValue[j], grid[i][j] );
            }
        }

            for(int i = 0;i<n;i++){
                for(int j =0;j<n;j++){
                    res+=Math.Min(MaxRowValue[i],MaxColValue[j])-grid[i][j];
                }
            }
    return res;
    }
}