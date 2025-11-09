public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n = grid.Length*grid.Length;
        int[] uniq = new int[n+1];
        int[] res = new int[2];

        for(int i = 0 ;i<grid.Length;i++){
            for(int j = 0 ; j < grid[i].Length;j++){
                uniq[grid[i][j]]++;
            }
        }

        for(int k = 0; k<uniq.Length;k++){
            if(uniq[k] > 1 )res[0] = k;
            if(uniq[k] == 0) res[1] = k;
        }

        return res;

    }
}