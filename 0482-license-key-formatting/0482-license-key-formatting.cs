public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        int groupLength = 0;
        StringBuilder result = new StringBuilder();
        for(int i = s.Length-1 ; i >= 0; i--)
        {
            if(s[i] == '-') continue;
            if(groupLength == k)
            {
                result.Append("-");
                groupLength = 0;
            }

            result.Append(Char.ToUpper(s[i]));
            groupLength++;
        }
        char[] res = result.ToString().ToCharArray();
        Array.Reverse(res);
        return new string(res);
    }
}