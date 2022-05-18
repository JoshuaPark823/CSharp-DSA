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
    public bool IsSymmetric(TreeNode root) {
        
        if (root == null) {
            return true;
        }
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        
        q.Enqueue(root.left);
        q.Enqueue(root.right);
        
        while (q.Count > 0) {
            
            // Pop out both nodes from the front
            var node1 = q.Dequeue();
            var node2 = q.Dequeue();
            
            // If both nodes are null, continue
            // In the recursive solution we would return here.
            if (node1 == null && node2 == null) {
                continue;
            }
            
            // If one of the nodes is null, it is definitely not symmetric.
            // If we have both nodes but they have different values, not symmetric.
            if ((node1 == null || node2 == null) || (node1.val != node2.val)) {
                return false;
            }
            
            // Compare the left node of Tree 1 with right node of Tree 2
            q.Enqueue(node1.left); q.Enqueue(node2.right);
            q.Enqueue(node1.right); q.Enqueue(node2.left);
        }
        
        return true;
    }
    
}