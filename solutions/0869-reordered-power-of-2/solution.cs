public class Solution {
    public bool ReorderedPowerOf2(int n) {
        string target = SortDigits(n);
        for (int i = 0; i < 31; i++) {
            int powerOfTwo = 1 << i;
            if (SortDigits(powerOfTwo) == target) return true;
        }
        return false;
    }

    private string SortDigits(int num) {
        char[] digits = num.ToString().ToCharArray();
        Array.Sort(digits);
        return new string(digits);
    }
}
