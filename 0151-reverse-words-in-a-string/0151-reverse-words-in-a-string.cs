public class Solution {
    public string ReverseWords(string s)
{
    List<string> words = new List<string>();
    s = s.Trim();
    int left = 0;
    for (int i = 0; i <= s.Length; i++)
    {
        if (i == s.Length || s[i] == ' ')
        {
            if(i > left)
            {
                words.Add(s.Substring(left, i-left));
            }
            left = i+1;
        }
    }
    words.Reverse();
    return string.Join(" " , words);
}
}