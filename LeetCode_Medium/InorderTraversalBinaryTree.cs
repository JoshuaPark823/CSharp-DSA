public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var order = new List<int>();
        var stack = new Stack<TreeNode>();
        
        var curr = root;
        
        if (root == null) {
            return order;
        }
        
        while ((stack.Count > 0) || curr != null) {
            
            // go left most
            while (curr != null) {
                stack.Push(curr);
                curr = curr.left;
            }
            
            curr = stack.Pop();
            
            if (curr != null) {
                order.Add(curr.val);
            }
            
            curr = curr.right;
        }
        
        return order;
   }
}