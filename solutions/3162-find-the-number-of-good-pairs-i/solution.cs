public class Solution {
    public int NumberOfPairs(int[] nums1, int[] nums2, int k) {
        int res = 0;

        foreach(int n in nums1){
            foreach( int s in nums2){
                if(n % (s*k) == 0) res++;
            }
        }

        return res;
    }
}