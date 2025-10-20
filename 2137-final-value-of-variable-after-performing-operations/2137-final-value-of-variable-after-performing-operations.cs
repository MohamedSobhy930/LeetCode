public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int output = 0 ;
        for(int i = 0 ; i < operations.Length ; i++)
        {
            if(operations[i][1] == '+')
                output++;
            else
                output--;
        }
        return output;
    }
}