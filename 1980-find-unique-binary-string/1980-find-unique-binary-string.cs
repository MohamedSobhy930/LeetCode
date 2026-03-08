public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
       StringBuilder result = new StringBuilder();
       for(int i = 0 , j = 0 ; i < nums.Length ; i++, j++)
       {
        result.Append(nums[i][j] == '1' ? '0' : '1');
       }
       return result.ToString();
    }
}