package com.leetCode;
class BuySellStocksSolution {
    public int maxProfit(int[] prices) {
        int min = Integer.MAX_VALUE, max = 0, n = prices.length;
        for (int i = 0; i < n; i++) {
            min = Math.min(min, prices[i]);
            max = Math.max(max, prices[i] - min);
        }
        return max;
    }
}