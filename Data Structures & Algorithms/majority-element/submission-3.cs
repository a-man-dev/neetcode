public class Solution {
    public int MajorityElement(int[] nums) {
        var count = 0;
        var current = nums[0];

        foreach (var n in nums) {
            if (count == 0) {
                current = n;
            }
            if (n == current) {
                count++;
            }
            else {
                count--;

            }

        }

        return current;
    }
}