public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        int minAbsDiff = int.MaxValue;
        for(int i = 1 ; i < arr.Length ; i++)
        {
            minAbsDiff = Math.Min(minAbsDiff , arr[i] - arr[i-1]);
        }
        var result = new List<IList<int>>();
        for(int i = 1 ; i < arr.Length ; i++)
        {
            if(arr[i] - arr[i-1] == minAbsDiff)
                result.Add(new List<int> {arr[i-1] , arr[i]});
        }
        return result;
    }
}