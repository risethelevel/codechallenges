class Solution:
    def countElements(self, arr: List[int]) -> int:
        hash_set = set()
        for item in arr:
            hash_set.add(item)
        count = 0
        for k in arr:
            if k+1 in hash_set:
                count = count + 1
        return count