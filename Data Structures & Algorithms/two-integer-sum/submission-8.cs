public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexes = new Dictionary<int,int>();

        for (var i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            
            if (indexes.ContainsKey(diff)) {
                return [indexes[diff], i];
            }
            else {
                indexes[nums[i]] = i;
            }
        }

        return [];
    }
}
