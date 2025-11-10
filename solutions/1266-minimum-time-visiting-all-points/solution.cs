public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {

        int ans = 0;
        for (int i = 0; i < points.Length - 1; i++) {
            int currX = points[i][0];
            int currY = points[i][1];
            int targetX = points[i + 1][0];
            int targetY = points[i + 1][1];
            ans += Math.Max(Math.Abs(targetX - currX), Math.Abs(targetY - currY));
        }
        
        return ans;
    }
}
