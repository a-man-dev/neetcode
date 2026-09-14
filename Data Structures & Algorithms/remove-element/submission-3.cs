public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var result = 0;
        var next = 0;

        for(var i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[next] = nums[i];
                next++;
            }
        }

        return next;
    }
}