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
    public bool IsValidBST(TreeNode root) {
        return Traverse(root);
    }
    
    private bool Traverse(TreeNode root, int? min = null, int? max = null) {
        
        // Empty nodes are valid
        if (root == null) {
            return true;
        }
        
        // Compare with the min/max passed from the parent
        if ((max != null && root.val >= max) || (min != null && root.val <= min)) {
            return false;
        }
        
        return Traverse(root.left, min, root.val) && Traverse(root.right, root.val, max);
    }
}