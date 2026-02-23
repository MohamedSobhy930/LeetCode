public class Solution {
    public bool HasAllCodes(string s, int k) {
        HashSet<string> codes = new HashSet<string>();
        int totalcodes = Convert.ToInt32(Math.Pow(2,k));
        for(int i = 0 ; i <= s.Length - k; i++)
        {
            string sub = s.Substring(i , k);
            if(!codes.Contains(sub))
                codes.Add(sub);
            if(codes.Count == totalcodes)
                return true;
        }
        return codes.Count == totalcodes;
    }
}