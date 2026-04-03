public class Solution {
    public int MaxProfit(int[] prices) {
        // what the hell this works?
        int min = 0, substraction, maxProfit = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            if(i == 0)
                min = prices[i];

            if(prices[i] < min)
            {
                min = prices[i];
            }

            substraction = prices[i] - min;
            if(substraction > maxProfit)
                maxProfit = substraction; 

        }
        return maxProfit;
    }
}
