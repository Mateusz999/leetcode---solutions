public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        int[] ans = new int[46];
        for (int i = lowLimit; i <= highLimit; i++)
        {
            int sum = 0;
            int tmp = i;
            while (tmp > 0)
            {
                sum += tmp % 10;
                tmp /= 10;
            }
            ans[sum] += 1;
        }
        return ans.Max();
    }
}