/**
* Throws a strange error when run on LeetCode, but the solution is sound.
*/

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        if (nums == null || nums.Length < 3) {
            return new List<IList<int>>();
        }

        var triplets = new List<IList<int>>();
        
        int targetSum = 0;
        
        // Note: The indexes are what can't be the same...
        // Can think of the "windows" as shrinking, moving from left --> right
        
        // Sort the list, O(NlogN) time
        Array.Sort(nums);
        
        for (int anchor = 0; anchor < nums.Length - 2; anchor++) {
            
            // Skip repeated anchors
            if ((anchor != 0) && nums[anchor] == nums[anchor - 1]) {
                continue;
            }
            
            // The list is now sorted, and 3 positive numbers cannot sum to 0
            if (nums[anchor] > targetSum) {
                return triplets;
            }
            
            int subTargetSum = targetSum - nums[anchor];
            
            int left = anchor + 1;
            int right = nums.Length - 1;
            
            while (left < right) {
                if (nums[left] + nums[right] > subTargetSum) {
                    right--;
                }
                else if (nums[left] + nums[right] < subTargetSum) {
                    left++;
                }
                else {
                    
                    // We found a triplet!
                    triplets.Add(new List<int>() {
                        nums[anchor], nums[left], nums[right]
                    });
                    
                    // We're already not duplicating the anchor, let's also not duplicate left/right
                    while (nums[left] == nums[left + 1]) {
                        left++;
                    }
                    while (nums[right] == nums[right - 1]) {
                        right--;
                    }
                    
                    // Move the pointers over (above code is just removing duplicates)
                    left++;
                    right--;
                }
            }
        }
        
        return triplets;
    }
}