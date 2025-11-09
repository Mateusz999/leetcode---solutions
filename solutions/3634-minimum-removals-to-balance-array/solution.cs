public class Solution {
    public int MinRemoval(int[] nums, int k) {
        int maxDlugosc = 0;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {
            int left = i, right = nums.Length - 1, najlepszy = i;
            long granica = (long)nums[i] * k;  

            while (left <= right) {
                int srodek = (left + right) / 2;
                if ((long)nums[srodek] <= granica) {
                    najlepszy = srodek;
                    left = srodek + 1;
                } else {
                    right = srodek - 1;
                }
            }

            maxDlugosc = Math.Max(maxDlugosc, najlepszy - i + 1);
        }

        return nums.Length - maxDlugosc;
    }
}
