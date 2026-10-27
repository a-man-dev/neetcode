public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var result = new List<int>();

        for (var i = 0; i < 2; i++) {
            foreach (var n in nums) {
                result.Add(n);
            }
        }

        return result.ToArray();
    }
}