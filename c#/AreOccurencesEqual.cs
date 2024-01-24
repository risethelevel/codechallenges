using System;

public class Solution
{
    public bool AreOccurrencesEqual(string s)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>();
        HashSet<int> occurences = new HashSet<int>();

        foreach (char c in s)
        {
            counts[c] = counts.GetValueOrDefault(c, 0) + 1;
        }

        foreach (char key in counts.Keys)
        {
            occurences.Add(counts[key]);
        }

        return occurences.Count == 1;
    }
}
