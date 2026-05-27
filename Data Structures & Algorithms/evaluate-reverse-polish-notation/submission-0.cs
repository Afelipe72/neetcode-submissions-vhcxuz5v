public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> polish = new Stack<int>();

        foreach(string token in tokens)
        {
            if(Int32.TryParse(token, out int number))
            {
                polish.Push(number);
            }
            else
            {
                int b = polish.Pop();
                int a = polish.Pop();

                if(token == "+"){
                    polish.Push(a + b);
                }
                else if(token == "-"){
                    polish.Push(a - b);
                } 
                else if(token == "*"){
                    polish.Push(a * b);
                } 
                else if(token == "/"){
                    polish.Push(a / b);
                } 
            }
        }

        return polish.Pop();
    }
}