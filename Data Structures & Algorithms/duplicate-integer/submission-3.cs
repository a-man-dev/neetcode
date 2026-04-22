public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numbersSet = new HashSet<int>();

        foreach (var n in nums) {
            if (numbersSet.Contains(n)) {
                return true;
            }
            else {
                numbersSet.Add(n);
            }
        }

        return false;
    }
}