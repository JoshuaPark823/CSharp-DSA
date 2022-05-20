public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        // Edge case: empty string
        if (s == String.Empty || s.Length == 0) {
            return 0;
        }
        
        var hashSet = new HashSet<char>();

        var longestSubstr = 0;
        
        var windowStart = 0;
        var windowEnd = 0;
        
        while (windowEnd < s.Length) {
            
            // Next Character is still distinct
            if (!hashSet.Contains(s[windowEnd])) {
                
                // Add it to our hashset since we're including it
                hashSet.Add(s[windowEnd]); 
                
                // Move the window along
                windowEnd++; 
                
                // Now the new maxLength is going to be the max between the previous and the
                // current size of the window.
                longestSubstr = Math.Max(longestSubstr, windowEnd - windowStart);
            }
            
            // Next Character would be a repetition
            else {
                
                // Remove the windowStart character
                hashSet.Remove(s[windowStart]);
                
                // Move the window start along
                windowStart++;
            }
        }
        
        return longestSubstr;
    }
}