public class Solution {
    public int LastStoneWeight(int[] stones) {
        List<int> result = new List<int>(stones);
        while(result.Count > 1)
        {
            result.Sort();
            int n = result.Count;
            int heavy = result[n-1];
            int secHeavy = result[n-2];

            result.RemoveAt(n-1);
            result.RemoveAt(n-2);

            if(heavy != secHeavy)
            {
                result.Add(heavy-secHeavy);
            }
        }
        return result.Count == 0 ? 0 : result[0];
    }
}