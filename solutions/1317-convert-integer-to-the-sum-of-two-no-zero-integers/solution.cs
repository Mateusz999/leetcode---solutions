public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        bool Check(int x) {
            return !x.ToString().Contains('0');
        }
        for (int i = 1; i < n; i++) {
            int j = n - i;
            if (Check(i) && Check(j)) {
                return new int[] { i, j };
            }
        }
        return new int[0];
    }
}