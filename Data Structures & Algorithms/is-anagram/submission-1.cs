public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }

        var sFrequency = new Dictionary<char,int>();
        var tFrequency = new Dictionary<char,int>();

        foreach (var c in s) {
            if (sFrequency.ContainsKey(c)) {
                sFrequency[c]++;
            }
            else {
                sFrequency[c] = 1;
            }
        }

         foreach (var c in t) {
            if (tFrequency.ContainsKey(c)) {
                tFrequency[c]++;
            }
            else {
                tFrequency[c] = 1;
            }
        }

        if (sFrequency.Count != tFrequency.Count) {
            return false;
        }

        foreach (var sKeyValue in sFrequency) {
            if (!(tFrequency.ContainsKey(sKeyValue.Key) && sKeyValue.Value == tFrequency[sKeyValue.Key])) {
                return false;
            }
        }

        return true;

    }
}
