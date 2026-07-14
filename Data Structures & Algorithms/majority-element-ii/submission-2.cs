public class Solution {
    public List<int> MajorityElement(int[] nums) {
        var count = new Dictionary<int, int>();

        foreach (var n in nums){
            if (count.ContainsKey(n)) {
                count[n] += 1;
            }
            else {
                count[n] = 1;
            }

            if (count.Count <= 2) {
                continue;
            }

            var newCount = new Dictionary<int,int>();
            foreach (var kv in count) {
                if (kv.Value > 1) {
                    newCount[kv.Key] = kv.Value - 1;
                }
            }
            count = newCount;
        }

        var res = new List<int>();

        foreach (var kv in count) {
            if (nums.Count(n => n == kv.Key) > nums.Length/3) {
                res.Add(kv.Key);
            }
        }

        return res;
    }
}