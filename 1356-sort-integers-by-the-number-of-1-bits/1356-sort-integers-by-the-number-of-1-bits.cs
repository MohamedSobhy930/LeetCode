public class Solution {
    public int[] SortByBits(int[] arr) {
        return arr.OrderBy(x => CountBits(x))
        .ThenBy(x => x)
        .ToArray();
    }
    public int CountBits(int n)
    {
        int count = 0; 
        while(n > 0)
        {
            if((n & 1) == 1)
                count++;
            n >>= 1;
        }
        return count;
    }
}