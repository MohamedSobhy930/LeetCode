public class Solution {
    public string FindLongestWord(string s, IList<string> dictionary)
{
    string result = "";
    foreach (string word in dictionary)
    {
        if (isSubSequence(s ,word))
        {
            if(word.Length > result.Length)
                result = word;
            else if(word.Length == result.Length && string.Compare(word , result) < 0)
                result = word;
        }
    }
    return result;
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