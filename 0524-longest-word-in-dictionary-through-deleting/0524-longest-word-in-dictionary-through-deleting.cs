public class Solution {
    public string FindLongestWord(string s, IList<string> dictionary)
{
    dictionary = dictionary
        .OrderByDescending(x => x.Length)
        .ThenBy(x => x)
        .ToList();
    foreach (string word in dictionary)
    {
        if (isSubSequence(s ,word))
            return word;
    }
    return "";
}
public bool isSubSequence(string s ,string word)
{
    int j = 0;
    int i = 0;
    while (j < s.Length)
    {
        if (i == word.Length) return true;
        if (word[i] == s[j])
        {
            i++;
            j++;
        }
        else
            j++;
    }
    return i == word.Length;
}
}