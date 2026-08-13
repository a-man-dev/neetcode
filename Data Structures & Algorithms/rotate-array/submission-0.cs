public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;

        var l = 0;
        var r = nums.Length - 1;

        while (l < r) {
            var temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;

            l++;
            r--;
        }

        l = 0;
        r = k - 1;

        while (l < r) {
            var temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;

            l++;
            r--;
        }

        
        l = k;
        r = nums.Length - 1;

        while (l < r) {
            var temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;

            l++;
            r--;
        }
    }
}