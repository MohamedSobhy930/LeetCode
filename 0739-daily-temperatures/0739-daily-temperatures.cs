public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] result = new int[n];
        Stack<int> nextGreater = new Stack<int>();
        for(int i = 0 ; i < n ;i++)
        {
            while(nextGreater.Count > 0 && temperatures[i] > temperatures[nextGreater.Peek()])
            {
                int index = nextGreater.Pop();
                result[index] = i - index;
            }
            nextGreater.Push(i);
        }
        return result;
    }
}