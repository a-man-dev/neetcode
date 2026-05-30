public class Solution {

    public string Encode(IList<string> strs) {
        var builder = new StringBuilder();

        foreach (var s in strs) {
            builder.Append($"{s.Length}#{s}");
        }

        return builder.ToString();
    }

    public List<string> Decode(string s) {
        var words = new List<string>();
        var i = 0;

        while (i < s.Length) {
            var j = i;
            while (s[j] != '#') {
                j++;
            }

            var length = int.Parse(s[i..j]);
            var word = s[(j+1)..(j+1+length)];
            words.Add(word);
            i = j + 1 + length;
        }

        return words;
   }
}
