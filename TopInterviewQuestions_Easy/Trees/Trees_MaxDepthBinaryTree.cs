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
    public int MaxDepth(TreeNode root) {
        return Traverse(root, 0);
    }
    
    public int Traverse(TreeNode root, int depth) {
        if (root == null) {
            return depth;
        }
        
        return Math.Max(Traverse(root.left, depth + 1), Traverse(root.right, depth + 1));
    }
}