public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groupedMap = new Dictionary<string,List<string>>();

        foreach (var str in strs) {
            var count = new int[26];

            foreach (var s in str) {
                count[(int) s - (int) 'a'] += 1;
            }

            var key = string.Join(",", count);

            if (groupedMap.ContainsKey(key)) {
                groupedMap[key].Add(str);
            }
            else {
                groupedMap[key] = [str];
            }
        }

        return groupedMap.Values.ToList();
    }
}
