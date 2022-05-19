public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        // Edge Case: empty
        if ((nums1.Length == 0) || (nums2.Length == 0)) {
            return new int[0];
        }
        
        var returnList = new List<int>();
        
        List<int> smaller;
        List<int> bigger;
        
        if (nums1.Length <= nums2.Length) {
            smaller = new List<int>(nums1);
            bigger = new List<int>(nums2);
        }
        else {
            smaller = new List<int>(nums2);
            bigger = new List<int>(nums1);
        }
        
        // Now that we have the smaller list, iterate the smaller, check in the larger.
        foreach (int val in smaller) {
            if (bigger.Contains(val)) {
                returnList.Add(val); // push it onto the rt list
                bigger.Remove(val); // remove since we have added the el
            }
        }
        
        return returnList.ToArray();
    }
}