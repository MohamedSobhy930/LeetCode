public class Solution {
    public bool HasAllCodes(string s, int k) {
        HashSet<string> codes = new HashSet<string>();
        int totalcodes = 1 << k;
        for(int i = 0 ; i <= s.Length - k; i++)
        {
            string sub = s.Substring(i , k);
            codes.Add(sub);
            if(codes.Count == totalcodes)
                return true;
        }
        return codes.Count == totalcodes;
    }
}