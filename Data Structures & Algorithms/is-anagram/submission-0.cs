public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length || s == null || t == null) {
            return false;
        }
        var characters = t.ToList();

        foreach(var c in s) {
            if (characters.Contains(c)) {
                characters.Remove(c);
            }
        }

        return characters.Count == 0;
    }
}
