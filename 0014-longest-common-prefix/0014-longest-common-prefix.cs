public class Solution {
    public string LongestCommonPrefix(string[] strs)
{
    string result = "";
    int test = 0;
    string smallestByLength = strs.OrderBy(s => s.Length).First();
    for (int i = 0; i < smallestByLength.Length; i++)
    {
        for (int j = 0; j < strs.Length;j++)
        {
            if (strs[j][i] == strs[0][i])
                test++;
        }
        if(test == strs.Length)
        {
            result += strs[0][i]; 
        }
        if(test < strs.Length)
        {
            break;
        }
        test = 0;
    }
    return result;
}
}