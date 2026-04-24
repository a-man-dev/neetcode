public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (!nums?.Any() ?? true) {
            return false;
        }

        var numsSet = new HashSet<int>();

        foreach (var c in nums) {
            if (numsSet.Contains(c)) {
                return true;
            }
            else {
                numsSet.Add(c);
            }
        }

        return false;

    }
}