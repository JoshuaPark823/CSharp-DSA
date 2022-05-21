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
        
        bool Traverse(TreeNode root, int? min = null, int? max = null) {
            if (root == null) {
                return true;
            }
            
            if ((max != null && root.val >= max) || (min != null && root.val <= min)) {
                return false;
            }
            
            return Traverse(root.left, min, root.val) && Traverse(root.right, root.val, max);
        }
        
        return Traverse(root);
    }
}