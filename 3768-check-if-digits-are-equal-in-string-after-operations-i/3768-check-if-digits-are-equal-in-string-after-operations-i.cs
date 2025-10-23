public class Solution {
    public bool HasSameDigits(string s)
{
    while (s.Length > 2)
    {
        int n = s.Length; 
        char[] nextString = new char[n-1];
        for(int i = 0; i < n-1; i++ )
        {
            int sum = s[i] + s[i + 1] - 96;
            nextString[i] = (char)((sum % 10) + '0');
        }
        s = new string(nextString);
    }
    return s[0] == s[1];
}
}