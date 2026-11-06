public class Solution {
    public int MajorityElement(int[] nums) {
        var count = 0;
        var result = nums[0];

        foreach (var n in nums) {
            if (count == 0) {
                result = n;
            }

            if (n == result) {
                count++;
            }
            else {
                count--;
            }
        }

        return result;
    }
}