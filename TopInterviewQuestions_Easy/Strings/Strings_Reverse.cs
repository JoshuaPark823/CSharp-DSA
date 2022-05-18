public class Solution {
    public void ReverseString(char[] s) {
        
        // Two Pointers: Swap front/back characters as you iterate inwards
        // O(N/2) --> still O(N).
        
        for(int i = 0, j = s.Length - 1; i < j; i++, j--) 
        {
            var temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }
    }
}