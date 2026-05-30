public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var result = new int[2*nums.Length];
        var index = 0;

        for (var i = 0; i < 2; i++) {
            foreach (var n in nums) {
                result[index++] = n;
            }
        }

        return result;
    }
}