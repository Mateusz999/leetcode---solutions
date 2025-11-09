public class Solution {
    public int MaxSum(int[] nums) {
        HashSet<int> result = new HashSet<int>();

        foreach( int num in nums){
            if(num > 0) result.Add(num);
        }

        if(result.Count ==0 )return nums.Max();

        return result.Sum();
    }
}