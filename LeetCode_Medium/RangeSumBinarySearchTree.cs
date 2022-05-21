public class Solution {
    public int RangeSumBST(TreeNode root, int low, int high) {
        var sum = 0;
        
        void Traverse(TreeNode root) {
            if (root == null) {
                return;
            }
            
            Traverse(root.left);
            
            // logic
            if (root.val >= low && root.val <= high) {
                sum += root.val;
            }
            
            Traverse(root.right);
        }
        
        Traverse(root);
        
        return sum;
    }
}