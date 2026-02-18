public class Solution {
    public bool HasAlternatingBits(int n) {
        if(n == 1) return true;
        string binaryN = Convert.ToString(n , 2);
        int length = binaryN.Length;
        int i = 1; 
        while( i < length)
        {
            if(binaryN[i] == binaryN[i-1])
                return false;
            i++;
        }
        return true;
    }
}