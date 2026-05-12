public class Solution {
public bool IsValid(string s) {
    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        // opening brackets
        if (c == '(' || c == '[' || c == '{')
        {
            stack.Push(c);
        }
        else
        {
            // no matching opening
            if (stack.Count == 0)
                return false;

            char top = stack.Pop();

            if (c == ')' && top != '(') return false;
            if (c == ']' && top != '[') return false;
            if (c == '}' && top != '{') return false;
        }
    }

    return stack.Count == 0;
}
}
