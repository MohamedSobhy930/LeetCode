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
        int landFirstFinish = int.MaxValue;
        for(int i = 0 ; i < waterStartTime.Length; i++)
        {
            int finish = Math.Max(minLandEnd , waterStartTime[i]) + waterDuration[i];
            landFirstFinish = Math.Min(landFirstFinish, finish);
        }
        int waterFirstFinish = int.MaxValue;
        for(int i = 0 ; i < landStartTime.Length; i++)
        {
            int finish = Math.Max(minWaterEnd , landStartTime[i]) + landDuration[i];
            waterFirstFinish = Math.Min(waterFirstFinish, finish);
        }
        return Math.Min(landFirstFinish , waterFirstFinish);
    }
}