//C# Code
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private TreeNode helper(int[] nums, int s, int e){
        if(s > e)
            return null;
        int mid = s + (e - s) / 2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = helper(nums, s, mid - 1);
        node.right = helper(nums, mid + 1, e);
        return node;
    }
    
    public TreeNode SortedArrayToBST(int[] nums) {
        return helper(nums, 0, nums.Length - 1);
    }
}