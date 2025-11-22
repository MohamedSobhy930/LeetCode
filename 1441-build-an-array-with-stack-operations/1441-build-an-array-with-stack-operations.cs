public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> result = new List<string>();
        int index = 0;
        for(int i = 1 ; i <= n ; i++)
        {
            result.Add("Push");
            if(target[index] == i)
                index++;
            else 
                result.Add("Pop");
            if(index == target.Length) break;
            
        }
        return result;
    }
}