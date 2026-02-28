public class Solution {
    public int ConcatenatedBinary(int n) {
        int modulo = 1_000_000_007;
        int i = 1; 
        long result = 0;
        while(i <= n)
        {
            string s = Convert.ToString(i , 2);
            result <<= s.Length ;
            result |= i;
            result %= modulo;
            i++;
        }
    return (int)result;
    }
}