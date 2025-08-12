public class Solution {
    public int LengthOfLongestSubstring(string s)
{
    if(s.Length <= 1) return s.Length;

    int LongestSubstring = 0;
    int left = 0;
    HashSet<char> Unique = new HashSet<char>();
    for (int i = 0; i < s.Length; i++)
    {
        while(Unique.Contains(s[i]))
            {
                Unique.Remove(s[left]);
                left++;
            }
        Unique.Add(s[i]);
        LongestSubstring = Math.Max(LongestSubstring , i - left + 1);
    }
    return LongestSubstring;
}
}