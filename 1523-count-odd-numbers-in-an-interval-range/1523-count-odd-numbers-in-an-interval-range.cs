public class Solution {
    public int CountOdds(int low, int high) {
        int count = high - low + 1 ;
        int result = count / 2;
        if(count % 2 == 0) return result;
        return low % 2 == 0 ? result : result + 1;
    }
}