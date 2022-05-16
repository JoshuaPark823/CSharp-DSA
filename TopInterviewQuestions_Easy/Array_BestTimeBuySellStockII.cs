public class Solution {
    public int MaxProfit(int[] prices) {
        if (!prices.Any()) {
            return 0;
        }
        
        int profit = 0;
        int min = prices[0];
        
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] > min) {
                profit += prices[i] - min;
                min = prices[i];
            }
            else {
                min = prices[i];
            }
        }
        
        return profit;
    }
}