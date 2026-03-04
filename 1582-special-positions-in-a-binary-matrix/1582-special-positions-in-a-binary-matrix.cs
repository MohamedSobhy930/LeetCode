public class Solution {
    public int NumSpecial(int[][] mat) {
        int specialPos = 0;
        int m = mat.Length ; 
        int n = mat[0].Length;
        int[] rowCount = new int[n];
        int[] colCount = new int[m];
        for(int i = 0 ; i < m ; i++)
        {
            for(int j = 0 ; j < n ; j++)
            {
                if(mat[i][j] == 1)
                {
                    rowCount[j] += 1;
                    colCount[i] += 1;
                }
            }
        }
        for(int i = 0 ; i < m ; i++)
        {
            for(int j = 0 ; j < n ; j++)
            {
                if(mat[i][j] == 1)
                {
                    if(rowCount[j] == 1 && colCount[i] == 1)
                        specialPos++;
                }
            }
        }
        return specialPos;
    }
    //[0,0,0,0,0,0,0,0,0,0]
    //[0,1,0,0,0,0,1,0,0,0]
    //[1,0,0,1,0,0,0,1,0,0]
    //[0,0,0,0,0,1,0,0,0,1]
}