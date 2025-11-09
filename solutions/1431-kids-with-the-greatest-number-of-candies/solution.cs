public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> isGreatest = new List<bool>();
        for(int i = 0 ;i<candies.Length;i++){
            if(candies.Max() <= candies[i] + extraCandies) isGreatest.Add(true);
            else  isGreatest.Add(false);
        }
        return isGreatest;
    }
}