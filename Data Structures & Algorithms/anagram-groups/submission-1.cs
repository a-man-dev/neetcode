public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         var allKeyValues = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var keyCounts = new int[26];

            foreach (var s in str) {
                keyCounts[s - 'a']++;
            }

            var strKey = string.Join("#", keyCounts);

            if (!allKeyValues.ContainsKey(strKey)) {
                allKeyValues[strKey] = new List<string>();
            }

            allKeyValues[strKey].Add(str);
        }

        return allKeyValues.Values.ToList();
    }
}
