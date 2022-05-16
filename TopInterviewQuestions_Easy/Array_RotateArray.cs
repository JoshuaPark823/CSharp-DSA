public class Solution {
    public void Rotate(int[] nums, int k) {
        if (k == nums.Length) {
            return;
        }
        
        if (k > nums.Length) {
            k = k % nums.Length;
        }
        int size = nums.Length;
        int[] rotatedNums = new int[size];
        
        for (int i = 0; i < size; i++) {
            int newIndex = (i + k) % size;
            rotatedNums[newIndex] = nums[i];
        }
        
        for (int i = 0; i < size; i++) {
            nums[i] = rotatedNums[i];
        }
    }
}