public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numsSet = new HashSet<int>();

        foreach (var n in nums) {
            if (numsSet.Contains(n)) {
                return true;
            }
            numsSet.Add(n);
        }

        return false;
    }
}