public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        int totalAppleSum = 0;
        for(int i = 0 ; i < apple.Length ; i++)
        {
            totalAppleSum += apple[i];
        }
        Array.Sort(capacity);
        int result = 0;
        int index = capacity.Length - 1;
        while(true)
        {
            if(totalAppleSum > capacity[index])
            {
                totalAppleSum -= capacity[index];
                index--;
                result++;
            }
            else 
            {
                return result + 1;
            }
        }
        return result;
    }
}