public class Solution {
    public StringBuilder result = new StringBuilder("0");
    public char FindKthBit(int n, int k) {
        if(n < 1 || result.Length >= k)
            return result[k-1];
        string s = result.ToString();
        result.Append("1" + Reverse(Invert(s)));
        return FindKthBit(n-1 , k);
        
    }
    private string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    private string Invert(string s)
    {
        char[] charArray = s.ToCharArray();
        for(int i = 0 ; i < s.Length ; i++)
        {
            charArray[i] = s[i] == '0' ? '1' : '0';
        }
        return new string(charArray);
    }
}