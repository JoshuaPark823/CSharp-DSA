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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var q = new Queue<TreeNode>();
        var result = new List<IList<int>>();
        
        if (root == null) {
            return result;
        }
        
        q.Enqueue(root);
        
        while (q.Count != 0) {
            
            var qLength = q.Count;
            var row = new List<int>();
            
            for (int i = 0; i < qLength; i++) {
                var child = q.Dequeue();
                
                if (child.left != null) q.Enqueue(child.left);
                if (child.right != null) q.Enqueue(child.right);
                
                if (child != null)
                    row.Add(child.val);
            }
            
            result.Add(row);
        }
        
        return result;
    }
}