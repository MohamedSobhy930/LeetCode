public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> result = new HashSet<int>();
        HashSet<int> resultSet = new HashSet<int>(nums1);   
        for(int i = 0 ; i < nums2.Length ; i++)
        {
            if(resultSet.Contains(nums2[i]))
            {
                result.Add(nums2[i]);
            }
        }
        return result.ToArray();
    }
}