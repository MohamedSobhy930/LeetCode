public class MinStack
{
    private Stack<int> stack ;
    private Stack<int> sortedStack;
    public MinStack()
    {
        stack = new Stack<int>();
        sortedStack = new Stack<int>();
    }
    public void Push(int val)
    {
        stack.Push(val);
        if(sortedStack.Count == 0 || val <= sortedStack.Peek())
              sortedStack.Push(val);
    }

    public void Pop()
    {
        if (stack.Count == 0) return;

        int removed = stack.Pop();
        if (removed == sortedStack.Peek())
            sortedStack.Pop();   
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return sortedStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */