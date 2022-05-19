public class Solution {
    public int SingleNumber(int[] nums) {
        
        // Edge Case: 1 item
        if (nums.Length == 1) {
            return nums[0];
        }
        
        // Use Dictionary for constant lookup time
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        // Find the 1
        foreach (int num in nums) {
            if (map.ContainsKey(num)) {
                map[num] = 2;
            }
            else {
                map.Add(num, 1);
            }
        }
        
        // Return the 1
        foreach(var item in map) {

            if (item.Value == 1) {
                return item.Key;
            }
        }
        
        return 0;
    }
}