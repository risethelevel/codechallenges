public class Solution {
    public int MaximumSum(int[] nums) {
        var dic = new Dictionary<int,int>(){};
        int ans = -1;

        for(int i = 0; i < nums.Length; i++){
            var digitValue = GetSumOfDigits(nums[i]);

            if(dic.ContainsKey(digitValue)){
                ans = Math.Max(ans, nums[i] + dic[digitValue]);
            }

            dic[digitValue] = Math.Max(dic.GetValueOrDefault(digitValue, 0), nums[i]);
        }

        return ans;
    }

    private int GetSumOfDigits(int num){
        int sum = 0;
        while(num > 0){
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}