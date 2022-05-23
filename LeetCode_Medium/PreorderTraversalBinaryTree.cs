public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        // root, left, right
        
        var stack = new Stack<TreeNode>();
        var res = new List<int>();
        
        if (root == null)
            return res;
        
        stack.Push(root);
        
        while (stack.Count != 0) {
            var node = stack.Pop();
            
            if (node != null)
                res.Add(node.val);
            
            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }
        
        return res;
    }
}