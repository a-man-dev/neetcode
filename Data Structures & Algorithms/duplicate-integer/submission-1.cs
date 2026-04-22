public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (!nums?.Any() ?? true) {
            return false;
        }

        var numbersDict = new Dictionary<int, string>();

        foreach (var n in nums) {
            if (numbersDict.ContainsKey(n)) {
                return true;
            }
            else {
                numbersDict.Add(n, string.Empty);
            }
        }

        return false;
    }
}