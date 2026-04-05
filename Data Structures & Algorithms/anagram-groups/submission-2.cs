public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
        foreach(string word in strs)
        {
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string key = new string(charArray);

            if(!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
            }

            anagrams[key].Add(word);


        }
        Console.WriteLine(anagrams);
        return anagrams.Values.ToList();
    }
}
