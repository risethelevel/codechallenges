public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> counts = new Dictionary<int,int>();
        counts[0] = 1;
        int ans = 0;
        int curr = 0; //track prefix sum

        foreach(int num in nums){
            curr += num;
            ans += counts.GetValueOrDefault(curr - k, 0); // the frequency of curr - k is equal to the number of subarrays whose sum is equal to k
            counts[curr] = counts.GetValueOrDefault(curr, 0) + 1;
        }

        return ans;
    }
}