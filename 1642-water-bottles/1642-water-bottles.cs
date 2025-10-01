public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int maxOfDrinkedBottles = numBottles;
        int numofEmptyBottles = numBottles;
        while(numofEmptyBottles >= numExchange)
        {
            int newFullBottles = numofEmptyBottles / numExchange;
            int leftoverEmpty = numofEmptyBottles % numExchange;

            maxOfDrinkedBottles += newFullBottles;
            numofEmptyBottles = leftoverEmpty + newFullBottles;
            
        }
        return maxOfDrinkedBottles;
    }
}