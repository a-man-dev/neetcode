public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();

        var frequency = new List<int>[nums.Length+1];
        for (var i = 0; i < frequency.Length; i++) {
            frequency[i] = new List<int>();
        }

        foreach (var n in nums) {
            if (count.ContainsKey(n)) {
                count[n]++;
            }
            else {
                count[n] = 1;
            }
        }

        foreach (var keyValue in count) {
            frequency[keyValue.Value].Add(keyValue.Key);
        }

        var result = new List<int>();

        for (var i = frequency.Length - 1; i > 0; i--) {
            foreach (var n in frequency[i]) {
                result.Add(n);
                if (result.Count == k) {
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}
