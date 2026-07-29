public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var sb = new StringBuilder();

        var index1 = 0;
        var index2 = 0;

        while (index1 < word1.Length || index2 < word2.Length) {
            if (index1 < word1.Length) {
                sb.Append(word1[index1].ToString());
                index1++;
            }

            if (index2 < word2.Length) {
                sb.Append(word2[index2].ToString());
                index2++;
            }
        }

        return sb.ToString();
    }
}