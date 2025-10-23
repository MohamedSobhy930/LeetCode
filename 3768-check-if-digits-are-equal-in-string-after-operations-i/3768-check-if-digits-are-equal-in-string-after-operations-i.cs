public class Solution {
    public bool HasSameDigits(string s)
{
    
    // string check = s;
    while (s.Length > 2)
    {
        string p = "";
        for(int i = 0; i < s.Length-1; i++ )
        {

        p += (s[i] + s[i + 1] - 96) % 10;
        }
        s = p;
    }
    return s[0] == s[1];
}
}