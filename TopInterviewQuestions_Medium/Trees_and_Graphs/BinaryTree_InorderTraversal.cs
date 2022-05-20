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

public class RecursiveSolution {
    public IList<int> InorderTraversal(TreeNode root) {
        
        var order = new List<int>();
        
        Traverse(root, order);
     
        return order;
    }
    
    public void Traverse(TreeNode root, List<int> order) {
        
        if (root == null) {
            return;
        }
        
        Traverse(root.left, order);
        
        order.Add(root.val);
        
        Traverse(root.right, order);
    }
}

public class IterativeSolution {
    public IList<int> InorderTraversal(TreeNode root) {
        
        if (root == null) {
            return new List<int>();
        }
        
        var stack = new Stack<TreeNode>();
        var order = new List<int>();
        
        var curr = root;
        
        while (curr != null || stack.Count > 0) {
            
            /* Reach the left most Node of the
            curr Node */
            while (curr != null)
            {
                /* place pointer to a tree node on
                   the stack before traversing
                  the node's left subtree */
                stack.Push(curr);
                curr = curr.left;
            }
 
            /* Current must be NULL at this point */
            curr = stack.Pop();
 
            if (curr != null)
                order.Add(curr.val);
                
            /* we have visited the node and its
               left subtree.  Now, it's right
               subtree's turn */
            curr = curr.right;
        }
        
        return order;
        
    }
}