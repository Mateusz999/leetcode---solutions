public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        int n = mat.Length;
        int m = mat[0].Length;
        IList<int> res = new List<int>();

        for (int k = 0; k < n + m - 1; k++) {
            List<int> temp = new List<int>();

            for (int i = 0; i < n; i++) {
                int j = k - i;
                if (j >= 0 && j < m) {
                    temp.Add(mat[i][j]);
                }
            }

            if (k % 2 == 0) {
                temp.Reverse(); 
            }

            foreach (int val in temp) {
                res.Add(val);
            }
        }

        return res.ToArray();
    }
}
