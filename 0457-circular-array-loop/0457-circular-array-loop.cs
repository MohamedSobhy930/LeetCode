public class Solution {
    public bool CircularArrayLoop(int[] nums) {
        int n = nums.Length; 
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] == 0) continue;
            HashSet<int> seen = new HashSet<int>();
            int j = i ; 
            bool isForward = nums[i] > 0; 
            while(true)
            {
                if((nums[j] > 0 ) != isForward) break;

                if(seen.Contains(j)) return true;

                seen.Add(j);

                int nextIndex = ((j + nums[j]) % n + n) % n;
                if(nextIndex == j) break;
                j = nextIndex; 
            }
            foreach(int index in seen)
                nums[index] = 0;
        }
        return false;
    }
}