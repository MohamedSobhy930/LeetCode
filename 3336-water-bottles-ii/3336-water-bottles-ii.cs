public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        int numofFullBottles = 0;
        int numofEmptyBottles = numBottles;
        int numofBottleDrunk = numBottles;
        while(numofFullBottles !=0 || numofEmptyBottles >= numExchange)
        {
            if(numofEmptyBottles >= numExchange)
            {
                numofEmptyBottles -= numExchange;
                numExchange++;
                numofFullBottles++;
            }
            else
            {
                numofBottleDrunk += numofFullBottles;
                numofEmptyBottles += numofFullBottles;
                numofFullBottles = 0;
            }
        }
        return numofBottleDrunk;
    }
}