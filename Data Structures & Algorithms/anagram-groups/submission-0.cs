public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var count = new int[26];

            foreach (var s in str) {
                count[s-'a']++; // s - 'a' char converted to ascii int to represent location of letter within array
            }

            var key = string.Join("#", count);

            if (!result.ContainsKey(key)) {
                result[key] = new List<string>();
            }

            result[key].Add(str);
        }

        return result.Values.ToList();
    }
}
