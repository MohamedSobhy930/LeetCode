public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        var map = new HashSet<int>(nums);
        while(true)
        {
            if(map.Contains(original))
                original *= 2;
            else 
                return original;
        }
        return original;
    }
}