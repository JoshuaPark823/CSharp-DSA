public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {

        // post order requires two stacks
        
        var s1 = new Stack<TreeNode>();
        var s2 = new Stack<TreeNode>();
        
        var order = new List<int>();
        
        if (root == null) {
            return order;
        }
        
        s1.Push(root);
        
        while (s1.Count > 0) {
            var temp = s1.Pop();
            s2.Push(temp);
            
            if (temp.left != null) s1.Push(temp.left);
            if (temp.right != null) s1.Push(temp.right);
        }
        
        while (s2.Count > 0) {
            var node = s2.Pop();
            
            if (node != null) {
                order.Add(node.val);
            }
        }
        
        return order;
    }
}