using System;

public class Solution
{
    public IList<int> Intersection(int[][] nums)
    {
        var counts = new Dictionary<int, int>();
        var ans = new List<int>();
        foreach (var arr in nums)
        {
            foreach (var num in arr)
            {
                counts[num] = counts.GetValueOrDefault(num, 0) + 1;
            }
        }
        var n = nums.Length;
        foreach (var key in counts.Keys)
        {
            if (counts[key] == n)
            {
                ans.Add(key);
            }
        }
        ans.Sort();
        return ans.ToArray();
    }
}
