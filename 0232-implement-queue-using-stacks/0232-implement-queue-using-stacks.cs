public class MyQueue {
    private Stack<int> stack1;
    private Stack<int> stack2;
    private int peek;
    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
        peek = -1;
    }
    
    public void Push(int x) {
       if(stack1.Count == 0)
            peek = x;
        stack1.Push(x);
    }
    
    public int Pop() {
        while(stack1.Count > 0)
        {
            stack2.Push(stack1.Pop());
        }
        int removed = stack2.Pop();
        if(stack2.Count> 0)
            peek = stack2.Peek();
        while(stack2.Count > 0)
        {
            stack1.Push(stack2.Pop());
        }
        return removed;
    }
    
    public int Peek() {
        return peek;
    }
    
    public bool Empty() {
        return stack1.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */