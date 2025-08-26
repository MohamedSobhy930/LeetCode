public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int maxArea = 0; 
        double maxDiagonal = 0;
        for(int i = 0 ; i < dimensions.Length ; i++)
        {
            int length = dimensions[i][0];
            int width = dimensions[i][1];
            double diagonal = Math.Sqrt(length * length + width * width);
            if(diagonal > maxDiagonal)
            {
                maxArea = length * width;
                maxDiagonal = diagonal;
            }
            else if(diagonal == maxDiagonal)
            {
                maxArea = Math.Max(maxArea , length * width);
            }
        }
        return maxArea;
    }
}