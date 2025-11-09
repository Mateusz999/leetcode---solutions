//C# Solution
public class Solution {
    public int MinElement(int[] nums) {
        var ans = Int32.MaxValue;
        foreach (var x in nums) {
            var sum = 0;
            var num = x;
            while (num != 0) {
                sum += num % 10;
                num /= 10;
            }
            ans = Math.Min(ans, sum);
        }
        return ans;
    }
}