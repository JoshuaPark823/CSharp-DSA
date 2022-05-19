public class Solution {
    public int[] PlusOne(int[] digits) {

        // Iterate from Least to Most significant
        for (int i = digits.Length - 1; i >= 0; i--) {
            
            // If the digit is less than 9, adding 1 is just what we need
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }
            
            // +1 will make it 10, set it as 0. The above condition will handle the carry.
            digits[i] = 0;
        }
        
        // If we reach here, it means that all of the values were 9 ie: 9999
        // Create a new empty int array (the default value in C# is 0 for int array)
        int[] rt = new int[digits.Length + 1];
        rt[0] = 1;
        
        return rt;
    }
}