public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var numSet = new HashSet<int>();

        foreach (var n in nums) {
            numSet.Add(n);
        }

        var start = 1;

        foreach (var n in numSet) {
            if (!numSet.Contains(start)) {
                return start;
            }
            start++;
        }

        return start;
    }
}