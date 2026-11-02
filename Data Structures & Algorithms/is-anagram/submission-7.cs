public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var countS = new Dictionary<char, int>();
        var countT = new Dictionary<char, int>();

        foreach (var l in s) {
            if (countS.ContainsKey(l)) {
                countS[l] += 1;
            }
            else {
                countS[l] = 1;
            }
        }

        foreach (var l in t) {
            if (countT.ContainsKey(l)) {
                countT[l] += 1;
            }
            else {
                countT[l] = 1;
            }
        }

        if (countS.Count != countT.Count) {
            return false;
        }

        foreach (var kv in countS) {
            if (!countT.ContainsKey(kv.Key) || countS[kv.Key] != countT[kv.Key]) {
                return false;
            }
        }

        return true;
    }
}
