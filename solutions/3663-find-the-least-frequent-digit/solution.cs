public class Solution {
    public int GetLeastFrequentDigit(int n) {
        int[] tab = new int[10];
        string num = n.ToString();

        foreach (char nn in num) {
            tab[nn - '0']++;
        }

        int min = Int32.MaxValue;
        int result = -1;

        for (int i = 0; i < 10; i++) {
            if (tab[i] > 0 && tab[i] < min) {
                min = tab[i];
                result = i;
            }
        }

        return result;
    }
}
