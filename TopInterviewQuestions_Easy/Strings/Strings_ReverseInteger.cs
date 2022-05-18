public class Solution {
    public int Reverse(int x) {
        var result = 0;
        
        while (x != 0)
        {
            // Extract the remainder value in the 1s place
            int lastDigit = x % 10;
            
            // Remove the remainder value so we don't re-count
            x = x / 10;

            // When checking to see we are going out of bounds for Integer, 
            // use MinValue or MaxValue divided by 10. This is because we are multiplying
            // by 10 in the below step.
            if (result > (int.MaxValue / 10) || result < (int.MinValue / 10))
                return 0;

            // The *10 is "pushing the digits left and adding a "0", ie: a 1's place
            // Add the lastDigit onto the 1's place
            result = result * 10 + lastDigit;
        }

        return result;
    }
}