public class Solution {
    public bool IsAnagram(string s, string t) {
        var frequencyS = new Dictionary<int,int>();
        var frequencyT = new Dictionary<int,int>();

        foreach(var c in s) {
            if (frequencyS.ContainsKey(c)) {
                frequencyS[c]++;
            }
            else {
                frequencyS.Add(c,1);
            }
        }

        foreach(var c in t) {
            if (frequencyT.ContainsKey(c)) {
                frequencyT[c]++;
            }
            else {
                frequencyT.Add(c,1);
            }
        }

        if (frequencyS.Count == frequencyT.Count) {
            foreach(var keyValue in frequencyS) {
                if (!frequencyT.ContainsKey(keyValue.Key) || keyValue.Value != frequencyT[keyValue.Key]) {
                    return false;
                }
            }
        }
        else {
            return false;
        }

        return true;
    }
}
