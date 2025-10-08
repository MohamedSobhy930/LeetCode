public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        int n = spells.Length ;
        int m = potions.Length;
        Array.Sort(potions);
        int[] result = new int[n];
        for(int i = 0 ; i < n ; i++)
        {
            int left = 0 ; 
            int right = m-1;
            int firstSuccessIndex = m;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if((long)spells[i] * potions[mid] >= success)
                {
                    right = mid -1;
                    firstSuccessIndex = mid;
                }
                else if((long)spells[i] * potions[mid] < success)
                    left = mid + 1;
            }
            result[i] = m-firstSuccessIndex;
        }
        return result;
    }
}