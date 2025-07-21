public class Solution {
    public string MakeFancyString(string s) {
        StringBuilder res = new StringBuilder();
        res.Append(s[0]);
        int freq = 1;
        for(int i = 1 ; i < s.Length ; i++)
        {
            if(s[i] != s[i-1])
            {
                res.Append(s[i]);
                freq = 1;
            }
            else if(freq < 2)
            {
                res.Append(s[i]);
                freq++;
            }
        }
        return res.ToString() ;
    }
}