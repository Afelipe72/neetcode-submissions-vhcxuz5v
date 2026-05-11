public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
        foreach(string word in strs)
        {
            char[] wordChar = word.ToCharArray();
            Array.Sort(wordChar);
            string wordSorted = new string(wordChar);
        
            if(!anagrams.ContainsKey(wordSorted))
            {
                anagrams[wordSorted] = new List<string>();
            }
            
            anagrams[wordSorted].Add(word);

        }
    return anagrams.Values.ToList();
    }
}
