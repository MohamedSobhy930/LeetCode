public class Solution {
    public int[] SumZero(int n) {
        int[] result = new int[n];
        int val = n / 2 * -1 ;
        for(int i = 0 ; i < n ; i++)
        {
            if(val == 0 && n % 2 == 0)
            {
                val++;
            }
            result[i] = val++;
        }
        return result;
    }
}