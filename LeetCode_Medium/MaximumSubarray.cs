/*
    Given an integer array nums, find the contiguous subarray (containing at least one number) 
    which has the largest sum and return its sum.

    A subarray is a contiguous part of an array.
*/

// Algorithm: Kadane's Algorithm

public class Solution {
    public int MaxSubArray(int[] nums) {
        
        var maxSoFar = nums[0];
        var maxSum = nums[0];
        
        for (int i = 1; i < nums.Length; i++) {
            maxSoFar = Math.Max(maxSoFar + nums[i], nums[i]);
            maxSum = Math.Max(maxSum, maxSoFar);
        }
        
        return maxSum;
    }
}