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
    public TreeNode BstFromPreorder(int[] preorder) {
        if(preorder == null || preorder.Length == 0) return null;

        TreeNode root = new TreeNode(preorder[0]);
        var left = new List<int>();
        var right = new List<int>();

        for(int i = 1;i<preorder.Length;i++){
            if(preorder[i] < root.val) left.Add(preorder[i]);
            else right.Add(preorder[i]);
        }

        root.left = BstFromPreorder(left.ToArray());
        root.right= BstFromPreorder(right.ToArray());
        return root;
    }
}