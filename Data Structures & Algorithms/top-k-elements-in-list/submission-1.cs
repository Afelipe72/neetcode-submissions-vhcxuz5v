public class Solution {
public int[] TopKFrequent(int[] nums, int k) {

    Dictionary<int, int> count = new Dictionary<int, int>();

    // count frequencies
    foreach (int num in nums)
    {
        if (!count.ContainsKey(num))
        {
            count[num] = 0;
        }

        count[num]++;
    }

    // sort by frequency descending
    return count
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(x => x.Key)
        .ToArray();
}
}
