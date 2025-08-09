public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 1)
            return true;
        if((n & 1) == 1 || n == 0)
            return false;
        bool check = false;
        double d = n/2;
        check = IsPowerOfTwo(Convert.ToInt32(Math.Ceiling(d)));
        return check;
    }
}