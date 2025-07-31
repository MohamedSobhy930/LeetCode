public class Solution {
    public int RomanToInt(string s)
{
    int SUM = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if(s[i] =='I')
        {
            
            SUM += 1; 
        }
        else if(s[i] == 'V')
        {
            SUM += 5;
        }
        else if (s[i] == 'X')
        {
            SUM += 10;
        }
        else if (s[i] == 'L')
        {
            SUM += 50;
        }
        else if (s[i] == 'C')
        {
            SUM += 100;
        }
        else if (s[i] == 'D')
        {
            SUM += 500;
        }
        else 
        {
            SUM += 1000;
        }
    }
    for(int j = 0;j < s.Length - 1; j++)
    {
        if(s[j] =='I')
        {
            if (s[j+1] =='V')
            {
                SUM -= 2;
            }
            else if(s[j+1] == 'X')
            {
                SUM -= 2;
            }
        }
        if (s[j] == 'X')
        {
            if (s[j + 1] == 'L')
            {
                SUM -= 20;
            }
            else if (s[j + 1] == 'C')
            {
                SUM -= 20;
            }
        }
        if (s[j] == 'C')
        {
            if (s[j + 1] == 'D')
            {
                SUM -= 200;
            }
            else if (s[j + 1] == 'M')
            {
                SUM -= 200;
            }
        }
    }
    return SUM;
}
}