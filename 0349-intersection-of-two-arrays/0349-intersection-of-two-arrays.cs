public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        List<int> result = new List<int>();
        int n = nums1.Length ;
        int m = nums2.Length; 
        int left1 = 0;
        int left2 = 0;
        while(left1 < n && left2 < m )
        {
            if(nums1[left1] < nums2[left2])
                left1++;
            else if(nums1[left1] > nums2[left2])
                left2++;
            else 
            {
                int curMatching = nums1[left1];
                result.Add(curMatching);
                while(left1 < n && nums1[left1] == curMatching) left1++;
                while(left2 < m && nums2[left2] == curMatching) left2++;
            }

        }
        return result.ToArray();
    }
}