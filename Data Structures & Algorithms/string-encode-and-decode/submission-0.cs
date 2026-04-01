public class Solution {

    // ENCODE
    public string Encode(List<string> strs) {

        StringBuilder sb = new StringBuilder();

        foreach (string s in strs) {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }

        return sb.ToString();
    }

    // DECODE
    public List<string> Decode(string str) {

        List<string> result = new List<string>();

        int i = 0;

        while (i < str.Length) {

            
            int j = i;
            while (str[j] != '#')
                j++;

            int length = int.Parse(str.Substring(i, j - i));

           
            j++;

            
            string s = str.Substring(j, length);
            result.Add(s);

            
            i = j + length;
        }

        return result;
    }
}
