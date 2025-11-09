/**
 * Definition for a binary /**
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
    public void helper(TreeNode root ,IList<int> arr){
        if(root == null)return ;
        helper(root.left , arr);
        arr.Add(root.val);
        helper(root.right , arr);
    }
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> arr = new List<int>();
        if(root == null)return arr;
        helper(root , arr);
        return arr; 
    }
}