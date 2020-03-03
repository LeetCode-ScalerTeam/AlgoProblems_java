package com.leetCode;
class BuySellStocksSolution {
    public int maxProfit(int[] prices) {
        if(prices.length <= 0)
                return 0;
        int max = prices[prices.length -1] , diffMax =0;
        //System.out.println("max "+max +" diffMax "+diffMax);
        for(int i = prices.length-2 ; i >= 0 ; i--){
            if(prices[i] <= max && diffMax < (max - prices[i]))
                diffMax = max - prices[i];
            else if(prices[i] > max)
                max = prices[i];
            //System.out.println("max "+max +" prices[i]=> "+prices[i]+" diffMax "+diffMax);
        }
        return diffMax;
    }
}