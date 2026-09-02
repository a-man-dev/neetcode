public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numFrequency = new Dictionary<int,int>();

        foreach (var n in nums) {
            if (numFrequency.ContainsKey(n)) {
                return true;
            }
            else {
                numFrequency.Add(n,1);
            }
        }

        return false;
    }
}