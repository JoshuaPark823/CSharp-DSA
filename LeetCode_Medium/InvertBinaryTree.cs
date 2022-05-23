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
    public TreeNode InvertTree(TreeNode root) {
    
        if (root == null) {
            return null;
        }
        
        var left = root.left;
        var right = root.right;
        
        root.left = InvertTree(right);
        root.right = InvertTree(left);
        
        return root;
    }
}

public class IterativeSolutionStack {
    public TreeNode InvertTree(TreeNode root) {
    
        if (root == null) {
            return null;
        }
        
        var stack = new Stack<TreeNode>();
        
        stack.Push(root);
        
        while (stack.Count != 0) {
            var node = stack.Pop();
            
            // Swap left/right subtrees
            var temp = node.left;
            node.left = node.right;
            node.right = temp;
            
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }
        
        return root;
    }
}

public class IterativeSolutionQueue1 {
    public TreeNode InvertTree(TreeNode root) {
    
        if (root == null) {
            return null;
        }
        
        var queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        
        while (queue.Count != 0) {
            var node = queue.Dequeue();
            
            // swap left/right subtree
            var temp = node.left;
            node.left = node.right;
            node.right = temp;
            
            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }
        
        return root;
    }
}

public class IterativeSolutionQueue2 {
    public TreeNode InvertTree(TreeNode root) {
        
        if (root == null)
            return null;
        
        var queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        
        while (queue.Count != 0) {
            var node = queue.Dequeue();
            
            if (node == null)
                continue;
            
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
            
            // Do the swap
            var left = node.left;
            node.left = node.right;
            node.right = left;
        }
        
        return root;
    }
}