public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        var pairs = new Dictionary<int,int>();
        int result = 0;

        foreach(var d in dominoes){
            int min = Math.Min(d[0], d[1]);
            int max = Math.Max(d[0],d[1]);

            int pairID = min * 10 + max;
            if(pairs.ContainsKey(pairID)){
                result += pairs[pairID];
                pairs[pairID]++;
            }else{
                pairs[pairID] = 1;
            }
        }
        return result;
    }
}