public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        // Two Pointers method
        
        int slowPointer = 0;
        
        for (int fastPointer = 0; fastPointer < nums.Length; fastPointer++) {
            
            if (fastPointer > 0 && nums[fastPointer] == nums[fastPointer - 1]) {
                continue;
            }
            
            nums[slowPointer] = nums[fastPointer];
            slowPointer += 1;
        }
        
        return slowPointer;
    }
}