public class Solution {
    public bool IsPalindrome(string s) {
        string reverseString = "";
        foreach(char c in s)
        {
            if(Char.IsLetterOrDigit(c))
            {
                reverseString +=Char.ToLower(c);
            }
        }
        return reverseString == new string(reverseString.Reverse().ToArray());
        
    }
}