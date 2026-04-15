public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int minDistance = int.MaxValue;
        int n = words.Length;
        int i = 0;
        while(i < n)
        {
            if(words[i] == target)
            {
                int forwardDis = Math.Abs(i - startIndex);
                int minDis = Math.Min(forwardDis , n - forwardDis);
                minDistance = Math.Min(minDis , minDistance);
            }
            i++;
        }
        return minDistance == int.MaxValue ? -1 : minDistance;
    }
}