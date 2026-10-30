public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var key = GetKey(str);
            if (groups.ContainsKey(key)) {
                groups[key].Add(str);
            }
            else {
                groups[key] = [str];
            }
        }

        return groups.Values.ToList();
    }

    string GetKey(string word) {
        var letterCount = new int[26];

        foreach (var s in word) {
            var index = s - 'a';
            letterCount[index]++;
        }

        return string.Join(",", letterCount);;
    }

}
