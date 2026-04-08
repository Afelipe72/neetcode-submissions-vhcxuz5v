public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();

        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            // if duplicate → shrink
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            // add current character
            set.Add(s[right]);

            // update max length
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
