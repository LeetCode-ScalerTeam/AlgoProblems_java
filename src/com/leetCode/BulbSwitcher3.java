package com.leetCode;


// Problem Statement : https://leetcode.com/contest/weekly-contest-179/problems/bulb-switcher-iii/
public class BulbSwitcher3 {
    public int numTimesAllBlue(int[] light) {
        int blueCount = 0 , onCount = 0, moment = 0, onLight[] = new int[light.length];
        for(int x = 0 ; x < light.length ; x++){
            int i = light[x]-1;
            onLight[i] = 1;
            onCount = Math.max(onCount, i);
            if(i == 0 || onLight[i-1] == 2){
                onLight[i] = 2;
                blueCount = i;
                for(int j = i+1 ; j <= onCount && j < light.length; j++){
                    if(onLight[j] == 1){
                        onLight[j] = 2;
                        blueCount = j;
                    }
                    else
                        break;
                }
                if(onCount == blueCount){
                    moment++;
                    //System.out.println(onCount);
                }
            }
        }
        return moment;
    }
}
