public class Solution {
    public int CountOdds(int low, int high) {
        int count = high - low + 1 ;
        if(count % 2 == 0) return count / 2 ;
        return low % 2 == 0 ? count / 2 : count / 2 +1;
    }
}