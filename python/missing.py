class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        present_list = { value:0 for value in range(0, len(nums)+1)}
        for n in nums:
            present_list[n] = 1
        for k, v in present_list.items():
            if v == 0:
                return k


                n(n-1)