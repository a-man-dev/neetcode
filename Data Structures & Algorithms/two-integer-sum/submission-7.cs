public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numIndex = new Dictionary<int,int>();

        for (var i = 0; i < nums.Length; i++) {
            var remainder = target - nums[i];

            if (numIndex.ContainsKey(remainder)) {
                return [numIndex[remainder], i];
            }
            else {
                numIndex[nums[i]] = i;
            }
        }

        return [-1,-1];
    }
}
