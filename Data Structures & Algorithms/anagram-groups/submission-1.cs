// this is trash
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        List<List<string>> returnList = new List<List<string>>();
        bool[] used = new bool[strs.Length];

        for (int i = 0; i < strs.Length; i++)
        {
            if (used[i]) 
                continue; // already grouped

            List<string> anagrams = new List<string>();

            char[] arr1 = strs[i].ToCharArray();
            Array.Sort(arr1);
            string word1 = new string(arr1);

            anagrams.Add(strs[i]);
            used[i] = true;

            for (int j = i + 1; j < strs.Length; j++)
            {
                if (used[j]) 
                    continue;

                char[] arr2 = strs[j].ToCharArray();
                Array.Sort(arr2);
                string word2 = new string(arr2);

                if (word1 == word2)
                {
                    anagrams.Add(strs[j]);
                    used[j] = true;
                }
            }

            returnList.Add(anagrams);
        }

        return returnList;
    }
}
