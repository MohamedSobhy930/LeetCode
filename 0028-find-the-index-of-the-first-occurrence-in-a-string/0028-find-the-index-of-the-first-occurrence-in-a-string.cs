public class Solution {
    public int StrStr(string haystack, string needle)
{
    if (string.IsNullOrEmpty(needle))
        return 0;
    if (needle.Length > haystack.Length)
        return -1;

    for(int j = 0 ; j <= haystack.Length- needle.Length; j++)
    {
        int i = 0;
        while (i < needle.Length && haystack[j+i] == needle[i])
        {
            i++;
        }
        if (i == needle.Length)
            return j;
    }
    return -1; 
}
}