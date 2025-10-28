public class Solution {
    public int CountValidSelections(int[] nums) {
        int selections = 0;
        int n = nums.Length;
        for(int i = 0 ; i < n ; i++)
        {
            if(nums[i] == 0) 
            {
                int[] numsCopy1 = (int[])nums.Clone();
                if(TryThisPath(numsCopy1 , i , "right"))
                    selections++;
                int[] numsCopy2 = (int[])nums.Clone();
                if(TryThisPath(numsCopy2 , i , "left"))
                    selections++;
            }
        }
        return selections;
    }
    public bool TryThisPath(int[] arr , int curr , string Direction)
    {
        while(curr >= 0 && curr < arr.Length)
        {
            if(arr[curr] == 0)
            {
                curr = Direction == "right" ? curr+1 : curr-1;
            }
            else if(arr[curr] > 0 )
            {
                arr[curr]--;
                Direction = Direction == "left" ? "right" : "left";
                
                curr = Direction == "right" ? curr+1 : curr-1;
            }
        }
        foreach(int num in arr)
        {
            if(num != 0)
                return false;
        }
        return true;
    }
}