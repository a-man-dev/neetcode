public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexValues = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++) {
            indexValues.Add(i, nums[i]);
        }

        foreach (var keyValue in indexValues) {
            var valueToAdd = target - keyValue.Value;
            var index = Array.IndexOf(nums, valueToAdd);
            if (index != -1 && index != keyValue.Key) {
                var higherIndex = keyValue.Key > index ? keyValue.Key : index;
                var lowerIndex = keyValue.Key < index ? keyValue.Key : index;
                return new int[] {lowerIndex, higherIndex};
            }
        }

        return new int[] {};
    }
}
