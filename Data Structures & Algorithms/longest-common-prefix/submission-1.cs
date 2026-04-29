public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return string.Empty;
        }

        if (strs.Length == 1) {
            return strs[0];
        }

        var res = "";

        for (var i = 0; i < strs[0].Length; i++) {
            foreach (var str in strs) {
                if (i == str.Length || strs[0][i] != str[i]) {
                    return res;
                }
            }
            res += strs[0][i];
        }

        return res;
    }
}