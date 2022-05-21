public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        
        // preorder = root, left, right
        
        var stack = new Stack<TreeNode>();
        var order = new List<int>();
        
        var curr = root;
        
        while (stack.Count > 0 || curr != null) {
        
            while (curr != null) {
                
                order.Add(curr.val);
                
                if (curr.right != null) {
                    stack.Push(curr.right);
                }
                
                curr = curr.left;
            }
            
            if (stack.Count != 0) {
                curr = stack.Pop();
            }
        }
        
        return order;
    }
}