public class Solution {
public bool CanJump(int[] nums) {
    int maxReach = 0;
    
    for (int i = 0; i < nums.Length; i++) {
        if (i > maxReach) return false; // nie możemy dojść do tego indeksu
        maxReach = Math.Max(maxReach, i + nums[i]);
    }
    
    return true;
}

}