public class Solution {
    public bool IsSubsequence(string s, string t) {
       if(s.Length == 0) return true;
       if(t.Length < s.Length) return false;
       int counter = 0 ; 
       for(int i = 0 ; i < t.Length ; i++)
       {
        if(s[counter] == t[i])
        {
            counter++;
        }
        if(counter == s.Length) 
        {
            return true;
        }
       }
       return counter == s.Length ? true : false; 
    }
}