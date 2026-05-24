public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequencyCount = new Dictionary<int, int>();
        var buckets = new List<int>[nums.Length + 1];

        foreach (var num in nums)
        {
            frequencyCount[num] =
                frequencyCount.GetValueOrDefault(num) + 1;
        }

        foreach (var entry in frequencyCount)
        {
            if (buckets[entry.Value] == null)
            {
                buckets[entry.Value] = new List<int>();
            }

            buckets[entry.Value].Add(entry.Key);
        }

        var result = new List<int>();

        for (var i = buckets.Length - 1; i > 0; i--)
        {
            if (buckets[i] == null)
            {
                continue;
            }

            foreach (var num in buckets[i])
            {
                result.Add(num);

                if (result.Count == k)
                {
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}