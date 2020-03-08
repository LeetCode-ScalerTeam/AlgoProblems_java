package com.leetCode;

public class TimeNeededToInformAllEmployees {
    int timeToGet[] = null;
    public int numOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        timeToGet = new int[n];
        for(int i = 0 ; i < n ; i++)
            timeToGet[i] = -1;
        timeToGet[headID] = 0;
        int max = 0;
        for(int i = 0 ; i < n ; i++){
            max = Math.max(ttg(i,manager,informTime), max);
        }
        return max;
    }
    int ttg(int x, int[] manager, int[] informTime){
        if(timeToGet[x] != -1)
            return timeToGet[x];
        else if(timeToGet[manager[x]] != -1){
            timeToGet[x] = timeToGet[manager[x]]+informTime[manager[x]];
        }
        else{
            timeToGet[x] = ttg(manager[x], manager, informTime)+informTime[manager[x]];
        }
        return timeToGet[x];
    }
}
