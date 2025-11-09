public class Solution {
    public int[] RecoverOrder(int[] order, int[] friends) {
        HashSet<int> friendSet = new HashSet<int>(friends);
        List<int> result = new List<int>();

        foreach (int num in order) {
            if (friendSet.Contains(num)) {
                result.Add(num);
            }
        }

        return result.ToArray();
    }
}