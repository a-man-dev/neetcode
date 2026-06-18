public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var common = "";

        for (var i = 0; i < strs[0].Length; i++) {
        

            foreach (var str in strs) {
                if (str.Length <= i || str[i] != strs[0][i]) {
                    return common;
                }
            }

            common += strs[0][i].ToString();
        }

        

        return common;
    }
}