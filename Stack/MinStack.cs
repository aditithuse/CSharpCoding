public class MinStack {

    private int value;
    private int min;
    private List<MinStack> stack;
    public MinStack()
    {
        stack = new List<MinStack>();
    }

    public void Push(int x)
    {
        if (stack.Count != 0) { 
            MinStack top = stack[stack.Count - 1];
            if (top.min > x)
                stack.Add(new MinStack() { value = x, min = x });
            else stack.Add(new MinStack() { value = x, min = top.min });
        }
        else
        {
            stack.Add(new MinStack() { value = x, min = x });
        }
    }

    public void Pop()
    {
        stack.RemoveAt(stack.Count - 1);
    }

    public int Top()
    {
        return stack[stack.Count - 1].value;
    }

    public int GetMin()
    {
        return stack[stack.Count - 1].min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
