public class Solution {
    public int HammingWeight(int n) {
        string binary = Convert.ToString(n, 2);
        int count = 0;
        foreach (char c in binary) {
            if (c == '1') count++;
        }
        return count;
    }
}
