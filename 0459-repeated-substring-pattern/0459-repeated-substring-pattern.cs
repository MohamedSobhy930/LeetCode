public class Solution {
    public bool RepeatedSubstringPattern(string s) {

        StringBuilder ss = new StringBuilder(s+s);
        ss.Remove(0,1);
        ss.Length--;

        
        return ss.ToString().Contains(s);
    }
}