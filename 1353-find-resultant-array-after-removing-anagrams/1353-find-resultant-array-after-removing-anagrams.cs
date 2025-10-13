public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        var result = new List<string>();
        result.Add(words[0]);
        int j = 0; 
        for(int i = 1 ; i < words.Length ; i++)
        {
            if(!AreAnagramsBySorting(words[j],words[i]))
            {
                result.Add(words[i]);
                j = i ; 
            }

        }
        return result;
    }
    public bool AreAnagramsBySorting(string s1, string s2) {
    if (s1.Length != s2.Length) return false;

    char[] a1 = s1.ToCharArray();
    char[] a2 = s2.ToCharArray();

    Array.Sort(a1);
    Array.Sort(a2);

    return a1.SequenceEqual(a2);
}
}