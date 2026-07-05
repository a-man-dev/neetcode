public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = nums.Select(n => 1).ToList();

        var prefix = 1;
        for (var i = 0; i < nums.Length; i++) {
            res[i] = prefix;
            prefix *= nums[i];
        }

        var postfix = 1;
        for (var i = nums.Length - 1; i > -1; i--) {
            res[i] *= postfix;
            postfix *= nums[i];
        }

        return res.ToArray();
    }
}
