public class NumMatrix {
    public int[][] prefix;
    public NumMatrix(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        prefix = new int[m][];
        for (int i = 0; i < m; i++) 
        {
            prefix[i] = new int[n + 1]; 
        }
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0 ; j < matrix[0].Length ; j++)
            {
                prefix[i][j+1] = prefix[i][j] + matrix[i][j];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int sum = 0; 
        int i = row1;
        while(i <= row2)
        {
            sum += prefix[i][col2+1] - prefix[i][col1];
            i++;
        }
        return sum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */