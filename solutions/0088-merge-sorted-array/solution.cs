public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
    
        if(n > 0 && m > 0){
            for(int j =0;j<n;j++){
                    nums1[j+m] = nums2[j]; 
                }
        }else{
            if(n > 0){
                for(int i =0;i<n;i++){
                    nums1[i] = nums2[i];
                }
            }
        }
                
                Array.Sort(nums1);
            
        }
    }
