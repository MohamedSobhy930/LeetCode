public class Solution {
    public bool IsHappy(int n) {
       if(n == 1 || n == 7)
        return true;
       if( n < 10)
        return false;
        HashSet<int> numbers = new HashSet<int> { 2, 3, 4, 5, 6, 8, 9 };
        int x = 0;
        while(n > 9)
        {
            while(n > 0)
            {
                x += (n % 10) * (n % 10);
                n /= 10;
            }
            if(numbers.Contains(x))
                return false;
            n = x ;
            x = 0 ;
        }
        if(n == 1 || n == 7)
            return true;
        return false;
    }
}