public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        int maxRaduis = 0; 
        Array.Sort(heaters);
        foreach(int house in houses)
        {
            int index = Array.BinarySearch(heaters , house);
            int minDistance;
            if(index >= 0)
                minDistance = 0;
            else
            {
                int insertionPoint = ~index ;

                int dist1 = (insertionPoint < heaters.Length) ? heaters[insertionPoint] - house : int.MaxValue;
                int dist2 = (insertionPoint > 0) ? house - heaters[insertionPoint-1]  : int.MaxValue;

                minDistance = Math.Min(dist1,dist2);
            }
            maxRaduis = Math.Max(maxRaduis, minDistance);

        }
        return maxRaduis;
    }
}