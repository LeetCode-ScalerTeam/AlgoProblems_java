package com.leetCode;

import java.util.ArrayList;
import java.util.Scanner;


class Interval {
     int start;
     int end;
     Interval() { start = 0; end = 0; }
     Interval(int s, int e) { start = s; end = e; }

    @Override
    public String toString() {
         return "( "+this.start+","+this.end+" )";
    }
}
class Solution {
    public ArrayList<Interval> insert(ArrayList<Interval> intervals, Interval newInterval) {
        newInterval = new Interval(Math.min(newInterval.start, newInterval.end),Math.max(newInterval.start, newInterval.end));
        if(intervals == null || intervals.size() == 0){
            intervals.add(newInterval);
            return intervals;
        }
        if(newInterval.start > intervals.get(intervals.size() -1).end){
            intervals.add(newInterval);
            return intervals;
        }
        if(newInterval.end < intervals.get(0).start){
            intervals.add(0,newInterval);
            return intervals;
        }
        int n = intervals.size();
        int i = 0;
        // Leaving intervals which are non-overlapping to the new intervals which are smaller than the new interval
        for(; i < n && newInterval.start > intervals.get(i).end ; i++);

        // Initializing max and min with new intervals values.
        int min = Math.min(newInterval.start, intervals.get(i).start), max =newInterval.end;

        // keeping a mark from which position the overlap has started.
        int initPos = i;

        /*
            After the first for loop we have the intervals which are either overlapping or are non-overlapping and
            are greater than te new interval.
            Now focus of the later part i.e. the non-overlapping intervals greater than the newInterval.
            In that case the newIntervals.end < intervals.start.
            So in this loop we are considering the opposite (newInterval.end > intervals.get(i).start) to find out the overlaps .
        */
        while(i < n && newInterval.end > intervals.get(i).start){
            max = Math.max(max, intervals.get(i).end);
            // Removing overlapping intervals
            intervals.remove(i);
            n--;
        }
        // Adding a new interval for all the overlaps
        intervals.add(initPos, new Interval(min, max));
        // Rest of the intervals are kept intack as they are strictly greater than the new Interval
        return intervals;

    }
}



public class MergeIntervals{
    public static void main(String args[]){
        try(Scanner sc = new Scanner(System.in)){
            String str[] = sc.nextLine().split(" ");
            int n = Integer.parseInt(str[0]);
            ArrayList<Interval> intervals = new ArrayList<>();
            for(int i = 1 ; i < str.length - 1 ; i+=2){
                intervals.add(new Interval(Integer.parseInt(str[i]),Integer.parseInt(str[i+1])));
            }
            str = sc.nextLine().split(" ");
            Interval interval = new Interval(Integer.parseInt(str[0]),Integer.parseInt(str[1]));
            System.out.println(new Solution().insert(intervals,interval));
        }catch(Exception ex){
            System.err.println("Runtime Exception");
            throw ex;
        }
    }
}
