public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int n = image.Length;
        int[][] result = new int [n][];
        for(int i = 0;i<n;i++){
            result[i] = new int[n];
        }

        for(int i = 0;i<n;i++){
            for(int j = 0;j<n;j++){
                result[i][j] = (image[i][n-j-1] == 1)? 0:1;
            }
        }

        return result;
    }
}