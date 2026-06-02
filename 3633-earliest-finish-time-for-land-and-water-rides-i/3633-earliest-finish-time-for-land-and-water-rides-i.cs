public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int minLandEnd = int.MaxValue;
        for(int i = 0 ; i < landStartTime.Length; i++)
        {
            minLandEnd = Math.Min(minLandEnd , landStartTime[i] + landDuration[i]);
        }
        int minWaterEnd = int.MaxValue;
        for(int i = 0 ; i < waterStartTime.Length; i++)
        {
            minWaterEnd = Math.Min(minWaterEnd , waterStartTime[i] + waterDuration[i]);
        }
        int landStarts = int.MaxValue;
        for(int i = 0 ; i < waterStartTime.Length; i++)
        {
            int finish = Math.Max(minLandEnd , waterStartTime[i]) + waterDuration[i];
            landStarts = Math.Min(landStarts, finish);
        }
        int waterStarts = int.MaxValue;
        for(int i = 0 ; i < landStartTime.Length; i++)
        {
            int finish = Math.Max(minWaterEnd , landStartTime[i]) + landDuration[i];
            waterStarts = Math.Min(waterStarts, finish);
        }
        return Math.Min(landStarts , waterStarts);
    }
}