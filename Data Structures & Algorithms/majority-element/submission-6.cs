public class Solution {
    public int MajorityElement(int[] nums) {
        var count = new Dictionary<int,int>();

        foreach (var n in nums) {
            if (count.ContainsKey(n)) {
                count[n] += 1;
            }
            else {
                count[n] = 1;
            }
        }

        foreach (var kv in count) {
            if (kv.Value > nums.Length / 2) {
                return kv.Key;
            }
        }

        return -1;
    }
}