public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var sumPairs = new PriorityQueue<int[],int>();
        var result = new List<IList<int>>();
        int n = k >= nums1.Length ? nums1.Length : k;
        for(int i = 0 ; i < n ; i++)
        {
            sumPairs.Enqueue(new int[]{i , 0} , nums1[i] + nums2[0]);
        }
        while(k > 0 && sumPairs.Count > 0)
        {
            int[] indecies = sumPairs.Dequeue();
            int i = indecies[0];
            int j = indecies[1];

            result.Add(new List<int>{nums1[i] , nums2[j]});

            if(j + 1 < nums2.Length )
            {
                sumPairs.Enqueue(new int[]{i , j+1} , nums1[i]+nums2[j+1] );
            }
            k--;
        }
        return result;
    }
}