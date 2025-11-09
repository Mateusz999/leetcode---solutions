public class Solution {
    public void SetZeroes(int[][] matrix) {
        int[] roww = new int[matrix.Length];
        int[] coll = new int[matrix[0].Length];
        int m = matrix.Length;
        int n = matrix[0].Length;

        for(int i = 0;i<m;i++){
            for(int j = 0;j<n;j++){
                if(matrix[i][j] == 0 ){
                    roww[i] = 1;
                    coll[j] = 1;
                }
            }
        }
        for(int i = 0; i<m;i++){
             for(int j = 0;j<n;j++){
                if(roww[i] == 1 || coll[j] == 1)matrix[i][j] = 0;
            }
        }
    
    }
}