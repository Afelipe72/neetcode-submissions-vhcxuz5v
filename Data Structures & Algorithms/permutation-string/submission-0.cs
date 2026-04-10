public class Solution
{
    public bool CheckInclusion(string s1, string s2) {
        int targetLength = s1.Length;
        int left = 0;
        List<char> letters = new List<char>();

        // sort s1 once
        var sortedS1 = s1.ToList();
        sortedS1.Sort();

        for(int right = 0; right < s2.Length; right++)
        {
            letters.Add(s2[right]);

            if(letters.Count > targetLength)
            {
                letters.RemoveAt(0); // remove leftmost
            }

            if(letters.Count == targetLength)
            {
                // copy the list to a char list
                var temp = new List<char>(letters);
                temp.Sort();

                if(temp.SequenceEqual(sortedS1))
                {
                    return true;
                }
            }
        }
        return false;
    }
}