public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var builder = new StringBuilder();

        for (var i = 0; i < strs[0].Length; i++) {
            foreach (var s in strs) {
                if (i >= s.Length || s[i] != strs[0][i]) {
                    return builder.ToString();
                }
            }

            builder.Append(strs[0][i]);
        }

        return builder.ToString();
    }
}