public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> result = new List<int>();
        int n = nums.Length; 
        for(int i = 0 ; i < n ; i++)
        {
            int num = nums[i];
            if(num < 10) result.Add(num);
            else
            {
                List<int> split = new List<int>();
                while(num > 0)
                {
                    split.Add(num % 10) ; 
                    num /= 10;
                }
                for(int j = split.Count - 1; j >= 0 ; j--)
                {
                    result.Add(split[j]);
                }
            }
        }
        return result.ToArray();
    }
}