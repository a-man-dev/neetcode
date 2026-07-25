public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;

        while (left < right) {
            while (left < right && !IsAlphaNumeric(s[left])) {
                left++;
            }
            while (right > left && !IsAlphaNumeric(s[right])) {
                right--;
            }
            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    public bool IsAlphaNumeric(char c)
    {
        return ('A' <= c && c <= 'Z') ||
            ('a' <= c && c <= 'z') ||
            ('0' <= c && c <= '9');
    }
}
