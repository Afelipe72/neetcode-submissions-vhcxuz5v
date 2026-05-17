public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int> numbers = new Stack<int>();

        for(int i = 0; i < temperatures.Length; i++)
        {
            while(numbers.Count > 0 && temperatures[i] > temperatures[numbers.Peek()])
            {
                int prevIndex = numbers.Pop();
                result[prevIndex] = i - prevIndex;
            }
            numbers.Push(i);
        }
        return result;
    }
}
