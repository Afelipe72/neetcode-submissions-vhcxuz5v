public class Solution {
    public bool IsPalindrome(string s)
    {
        string palindrome = "";
        foreach(char w in s)
        {
            if(char.IsLetterOrDigit(w))
            {
                palindrome += char.ToLower(w);
            }
        }
        return palindrome == new string(palindrome.Reverse().ToArray());
    }
}