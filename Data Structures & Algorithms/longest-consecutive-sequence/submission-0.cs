public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        var longest = 0;

        foreach (var n in nums) {
            if (!set.Contains(n-1)) {
                var length = 0;
                while (set.Contains(n+length)) {
                    length++;
                }
                longest = int.Max(longest, length);
            }
        }

        return longest;
    }
}
