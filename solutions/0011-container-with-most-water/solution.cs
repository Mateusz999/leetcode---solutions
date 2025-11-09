public class Solution {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxArea = 0;

        while (left < right) {
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            maxArea = Math.Max(maxArea, h * w);

            // Przesuwamy niższy słupek do środka
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }
}
