public class Solution {
    public string LargestGoodInteger(string num)
{
    StringBuilder res = new StringBuilder();
    for(int i = 0; i < num.Length-2;i++)
    {
        string s = num.Substring(i, 3);
        int j = 0; 
        while(j < s.Length)
        {
            if (s[j] != s[0])
            {
                break;
            }
            j++;
        }
        if (j == 3)
        { 
            if(res.Length == 0)
                res.Append(s);
            else if(s[0] > res[0])
            {
                res.Clear();
                res.Append(s);
            }
            i += 2;
        }
    }
    return res.ToString();
}
}