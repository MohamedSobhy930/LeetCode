public class Solution {
    public bool RepeatedSubstringPattern(string s) {

        string ss = s+s;
        string res = ss.Substring(1 , ss.Length - 2);

        return res.Contains(s);
    }
}