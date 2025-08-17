public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> s1 = new Dictionary<char,char>();
        Dictionary<char,char> t1 = new Dictionary<char,char>();
        for(int i = 0 ; i < s.Length ; i++)
        {
            if(s1.ContainsKey(s[i]))
            {
                if(s1[s[i]] != t[i]) return false;
            }
            else
            {
                s1[s[i]] = t[i];
            }
            if(t1.ContainsKey(t[i]))
            {
                if(t1[t[i]] != s[i]) return false;
            }
            else
            {
                t1[t[i]] = s[i];
            }
        }
        return true;
    }
}