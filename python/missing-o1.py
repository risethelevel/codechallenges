class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        total=sum(nums)
        return int((len(nums) * (len(nums)+1))/2 - total)
        
        