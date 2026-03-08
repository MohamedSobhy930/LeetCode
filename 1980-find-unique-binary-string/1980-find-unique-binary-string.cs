public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
       HashSet<string> allStrings = new HashSet<string>();
       int n = Convert.ToInt32(Math.Pow(2 , nums.Length));
       for(int i = 0 ; i < n ; i++)
       {
        string s = Convert.ToString(i , 2).PadLeft(nums.Length , '0');
        allStrings.Add(s);
       } 
       for(int i = 0 ; i < nums.Length ; i++)
       {
        if(allStrings.Contains(nums[i]))
            allStrings.Remove(nums[i]);
       }
       return allStrings.First();
    }
}