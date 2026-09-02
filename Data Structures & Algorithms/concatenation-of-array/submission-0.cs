public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var resultNums = new int[nums.Length*2];

        for (var i = 0; i < 2 * nums.Length; i++) {
            if (i > nums.Length - 1) {
                resultNums[i] = nums[i%nums.Length];
            }
            else {
                resultNums[i] = nums[i];
            }
        }

        return resultNums;
    }
}