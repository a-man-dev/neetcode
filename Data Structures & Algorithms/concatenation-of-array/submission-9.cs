public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var ans = new List<int>();

        for (var i = 0; i < 2; i++) {
            foreach (var n in nums) {
                ans.Add(n);
            }
        }

        return ans.ToArray();
    }
}