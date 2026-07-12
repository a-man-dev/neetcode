public class Solution {
    public List<int> MajorityElement(int[] nums) {
        var count = nums.Length/3;

        var numsCount = new Dictionary<int,int>();

        foreach (var n in nums) {
            if (numsCount.ContainsKey(n)) {
                numsCount[n] += 1;
            }
            else {
                numsCount[n] = 1;
            }
        }

        return numsCount.Where(kv => kv.Value > count).Select(kv => kv.Key).ToList();
    }
}