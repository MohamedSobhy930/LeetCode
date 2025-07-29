public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Length;
        int starting = 0;
        int tank = 0 ; 
        int totalgas = 0; 
        int totalcost = 0;
        for(int i = 0 ; i < n ; i++)
        {
            totalgas += gas[i];
            totalcost += cost[i];
            tank += gas[i] - cost[i] ;
            if(tank < 0)
            {
                starting = i + 1;
                tank = 0;
            }
        }
        return totalgas >= totalcost ? starting : -1;
    }
}