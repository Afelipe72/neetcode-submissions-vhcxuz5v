public class MinStack {

    private List<int> stack;

    public MinStack() {
        stack = new List<int>();
    }

    public void Push(int val) {
        stack.Add(val);
    }

    public void Pop() {
        stack.RemoveAt(stack.Count - 1);
    }

    public int Top() {
        return stack[stack.Count - 1];
    }

    public int GetMin() {
        return stack.Min();
    }
}