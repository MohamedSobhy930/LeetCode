public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        if(matrix.Length == 1) return new List<int>(matrix[0]);
        int m = matrix.Length ; 
        int n = matrix[0].Length;
        int top = 0, bottom = m-1;
        int left = 0 , right = n-1;
        List<int> res = new List<int>();
        while(top <= bottom && left <= right)
        {
            for(int i = left ; i <= right ; i++)
            {
                res.Add(matrix[top][i]);
            }
            top++;
            for(int i = top; i <= bottom ; i++)
            {
                res.Add(matrix[i][right]);
            }
            right--;
            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                    res.Add(matrix[bottom][j]);
                bottom--;
            }
            if(left <= right)
            {
                for(int i = bottom; i >= top ; i--)
                {
                    res.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return res;
    }
}