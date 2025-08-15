public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i = 0 ; i < 9 ; i++)
        {
        HashSet<char> check = new HashSet<char>();
            for(int j = 0 ; j < 9 ; j++)
            {
                if(board[i][j] != '.' && !check.Add(board[i][j]))
                {
                    return false;
                }
            }
        }
        for(int i = 0 ; i < 9 ; i++)
        {
        HashSet<char> check = new HashSet<char>();
            for(int j = 0 ; j < 9 ; j++)
            {
                if(board[j][i] != '.' && !check.Add(board[j][i]))
                {
                    return false;
                }
            }
        }
        for(int boxrow = 0 ; boxrow < 3 ; boxrow++)
        {
            for(int boxcol = 0 ; boxcol < 3 ; boxcol++)
            {
                HashSet<char> check = new HashSet<char>();
                for(int i = 0 ; i < 3 ; i++)
                {
                    for(int j = 0 ; j < 3 ; j++)
                    {
                        char num = board[boxrow * 3 + i][boxcol * 3 + j];
                        if(num != '.' && !check.Add(num))
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
}