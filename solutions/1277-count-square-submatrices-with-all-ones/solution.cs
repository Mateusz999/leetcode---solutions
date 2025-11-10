public class Solution {
    public int CountSquares(int[][] matrix) {

       if(matrix.Length == 0 && matrix[0].Length == 0 && matrix == null) return 0;

       int m = matrix.Length;
       int n = matrix[0].Length;
       int result = 0 ;

       for(int i = 0; i<m;i++){
        for(int j = 0 ; j<n;j++){
            if(matrix[i][j] == 1 && i>0 && j>0){
                matrix[i][j] = Math.Min(
                        matrix[i - 1][j - 1],
                        Math.Min(matrix[i - 1][j], matrix[i][j - 1])
                    ) + 1;
            }
            result +=matrix[i][j];
        }

       }

       return result;

    }
}