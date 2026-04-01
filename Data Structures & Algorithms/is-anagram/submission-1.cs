

public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;

        List<char> sList = s.ToList();
        List<char> tList = t.ToList();

        sList.Sort();
        tList.Sort();

        return sList.SequenceEqual(tList);
    }
}
