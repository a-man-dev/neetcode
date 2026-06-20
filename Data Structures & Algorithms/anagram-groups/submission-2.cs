public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var keyIndexes = new Dictionary<string, List<string>>();
        
        for (var i = 0; i < strs.Length; i++) {
            var count = new int[26];

            foreach (var c in strs[i]) {
                count[(int) c % 26]++; 
            }

            var key = string.Join(",", count);

            if (keyIndexes.ContainsKey(key)) {
                keyIndexes[key].Add(strs[i]);
            }
            else {
                keyIndexes[key] = [strs[i]];
            }
        }

        return keyIndexes.Values.ToList();


    }
}
