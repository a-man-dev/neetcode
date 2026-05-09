public class Solution {
    public int MajorityElement(int[] nums) {
        var numFrequency = new Dictionary<int, int>();

        foreach (var n in nums) {
            if (numFrequency.ContainsKey(n)) {
                numFrequency[n]++;
            } 
            else {
                numFrequency[n] = 1;
            }
        }

        var maxFrequency = 0;
        var maxKey = 0;

        foreach (var keyValue in numFrequency) {
            if (keyValue.Value > maxFrequency) {
                maxFrequency = keyValue.Value;
                maxKey = keyValue.Key;
            }
        }

        return maxKey;
    }
}