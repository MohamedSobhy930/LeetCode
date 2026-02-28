public class Solution {
    public int ConcatenatedBinary(int n) {
        int modulo = 1_000_000_007;
        int i = 1; 
        long result = 0;
        int bitLength = 0;
        while(i <= n)
        {
            if((i & (i - 1)) == 0) bitLength++;
            result <<= bitLength ;
            result |= i;
            result %= modulo;
            i++;
        }
    return (int)result;
    }
}