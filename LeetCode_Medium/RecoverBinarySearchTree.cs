public class Solution {
    public void RecoverTree(TreeNode root) {
        
        // point: inorder traversal of a BST should be sorted
        TreeNode first = null;
        TreeNode second = null;
        TreeNode previous = new TreeNode(Int32.MinValue);
        
        Traverse(root);
        
        void Traverse(TreeNode root) {
            
            if (root == null) {
                return;
            }
            
            Traverse(root.left);
            
            if (first == null && previous.val >= root.val) {
                first = previous;
            }
            
            if (first != null && previous.val >= root.val) {
                second = root;
            }
            
            previous = root;
            
            Traverse(root.right);
        }
        
        var temp = first.val;
        first.val = second.val;
        second.val = temp;  
        
    }

}