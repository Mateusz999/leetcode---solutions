public class Solution {
    public int MaxSumDistinctTriplet(int[] x, int[] y) {
        int n = x.Length;
        
        // Dictionary to map each unique x-value to its maximum corresponding y-value
        Dictionary<int, int> maxYForX = new Dictionary<int, int>();
        
        for (int i = 0; i < n; i++) {
            if (maxYForX.TryGetValue(x[i], out int currentMaxY)) {
                maxYForX[x[i]] = Math.Max(currentMaxY, y[i]);
            } else {
                maxYForX[x[i]] = y[i];
            }
        }
        
        // Need at least 3 distinct x-values
        if (maxYForX.Count < 3) {
            return -1;
        }
        
        // Get all maximum y-values and sort in descending order
        List<int> maxYValues = maxYForX.Values.ToList();
        maxYValues.Sort((a, b) => b.CompareTo(a)); // Sort descending
        
        // Return sum of top 3 values
        return maxYValues[0] + maxYValues[1] + maxYValues[2];
    }
}