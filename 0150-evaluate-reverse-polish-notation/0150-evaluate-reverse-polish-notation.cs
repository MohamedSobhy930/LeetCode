public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens.Length == 1) return int.Parse(tokens[0]);
        Stack<int> nums = new Stack<int>();
        Stack<char> op = new Stack<char>();
        int result = 0;
        for(int i = 0 ; i < tokens.Length ; i++)
        {
            if(int.TryParse(tokens[i] ,out int num))
            {
                nums.Push(num);
            }
            else
            {
                if(op.Count() == 0)
                {
                    int b = nums.Pop();
                    int a = nums.Pop();
                    int res = ExecOp(a , b , tokens[i]);
                    nums.Push(res);
                    result = res;
                }
            }
        }
            return result;
    }
    public int ExecOp(int a, int b, string op)
    {
        if(op == "+")
            return a + b;
        else if(op == "-")
            return a - b;
        else if(op == "*")
            return a * b;
        else
            return a / b;
    }
}