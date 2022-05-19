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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // Concept: Same logic as the IsSymmetric, but instead of comparing left-right, compare left-left and right-right
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        // Enqueue both root nodes
        queue.Enqueue(p);
        queue.Enqueue(q);
        
        while (queue.Count > 0) {
            
            var node1 = queue.Dequeue();
            var node2 = queue.Dequeue();
            
            // In the recursive step, we would usually return here
            if (node1 == null && node2 == null) {
                continue;
            }
            
            // If one is null but the other isn't they're clearly not the same
            // If we have a different value in each tree, ofc not the same
            if ((node1 == null || node2 == null) || (node1.val != node2.val)) {
                return false;
            }
            
            // Compare p-Tree's left subtree with q-Tree's left subtree
            // Compare p-Tree's right subtree with q-Tree's right subtree
            queue.Enqueue(node1.left); queue.Enqueue(node2.left);
            queue.Enqueue(node1.right); queue.Enqueue(node2.right);
        }
        
        return true;
    }
}