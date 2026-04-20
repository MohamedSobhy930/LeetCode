public class Solution {
    public int MaxDistance(int[] colors) {
        if(colors.Length == 2) return 1;
        if(colors[0] != colors[colors.Length -1]) return colors.Length -1;
        int n = colors.Length;
        int rightDis = 0 ; 
        for(int i = n -2 ; i >= 0 ; i--)
        {
            if(colors[i] != colors[0])
            {
                rightDis = i;
                break;
            }
        }
        int leftDis = 0;
        for(int i = 1 ; i < n ; i++)
        {
            if(colors[i] != colors[n-1])
            {
                leftDis = n - i-1;
                break;
            }
        }
        return Math.Max(rightDis, leftDis);
    }
}