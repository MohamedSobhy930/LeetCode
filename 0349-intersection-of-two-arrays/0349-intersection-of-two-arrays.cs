public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        List<int> result = new List<int>();
        HashSet<int> resultSet = new HashSet<int>(nums1);   
        for(int i = 0 ; i < nums2.Length ; i++)
        {
            if(resultSet.Contains(nums2[i]))
            {
                result.Add(nums2[i]);
                resultSet.Remove(nums2[i]);
            }
        }
        return result.ToArray();
    }
}