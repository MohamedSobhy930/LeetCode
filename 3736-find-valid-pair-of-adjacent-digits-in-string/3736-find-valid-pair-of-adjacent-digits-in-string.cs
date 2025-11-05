public class Solution {
    public string FindValidPair(string s) {
        var freq = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(!freq.ContainsKey(c))
                freq[c] = 0;
            freq[c]++;
        }
        for(int i = 1; i < s.Length; i++)
        {
            if(s[i] != s[i-1])
            {
                if((s[i] - '0') == freq[s[i]] && (s[i - 1] - '0') == freq[s[i-1]])
                    return s.Substring(i-1,2);
            }
        }
        return "";
    }
}