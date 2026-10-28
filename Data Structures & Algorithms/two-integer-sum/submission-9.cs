public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var count = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++) {
            var remainder = target - nums[i];
            if (count.ContainsKey(remainder)) {
                return [count[remainder], i];
            }
            else {
                count[nums[i]] = i;
            }
        }

        return [-1,-1];
    }
}
