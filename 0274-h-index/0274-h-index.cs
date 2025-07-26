public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        int k = citations.Length ;
        for(int i = 0 ; i < citations.Length ; i++)
        {
            if(k <= citations[i])
                return k;
            k--;
        }
        return 0;
    }
}