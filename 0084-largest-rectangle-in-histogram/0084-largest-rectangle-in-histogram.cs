public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> indecies = new Stack<int>();
        int largestArea = 0;
        int n = heights.Length;
        for(int i = 0 ; i <= n ; i++)
        {
            int value = (i == n) ? 0 : heights[i];
            while(indecies.Count > 0 && heights[indecies.Peek()] > value)
            {
                int height = heights[indecies.Pop()];
                int width = (indecies.Count == 0) ? i : i - indecies.Peek() - 1;
                largestArea = Math.Max(largestArea , height * width);
            }
            indecies.Push(i);
        }
        return largestArea;
    }
}