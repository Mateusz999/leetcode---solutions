public class Solution {
    public void Rotate(int[][] matrix) {
        int[][] result = new int[matrix.Length][];
        for(int i = 0;i<matrix.Length;i++){
            for(int j = i+1;j<matrix.Length;j++){
                int temp = matrix[i][j];
                 matrix[i][j] = matrix[j][i];
                 matrix[j][i] = temp;
            }
        }

        for(int k = 0; k<matrix.Length;k++){
            Array.Reverse(matrix[k]);
        }
    }
}