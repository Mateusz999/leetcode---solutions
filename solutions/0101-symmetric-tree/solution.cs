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
    bool DFS(TreeNode root1,TreeNode root2){
        if(root1==null&&root2==null){
            return true;
        }
        if(root1==null||root2==null || root1.val!=root2.val){
            return false;
        }
        bool ok1=DFS(root2.right,root1.left);
        bool ok2=DFS(root2.left,root1.right);
        return ok1&&ok2?true:false;
    }
    public bool IsSymmetric(TreeNode root) {
        return DFS(root.left,root.right);
    }
}