public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        string ss = "";
        foreach(char c in s)
        {
            if(c == '-') continue;
            if(c >= 'a') 
                ss += Char.ToUpper(c);
            else 
                ss += c;
        }
        StringBuilder result = new StringBuilder();
        int firstGroup = ss.Length % k ;
        if(firstGroup > 0)
        {
            result.Append(ss.Substring(0,firstGroup));
            result.Append("-");
        }
        int i = firstGroup;
        while(i < ss.Length)
        {
            result.Append(ss.Substring(i , k));
            result.Append("-");
            i += k;
        }
        
        return result.ToString().Trim('-');
    }
}