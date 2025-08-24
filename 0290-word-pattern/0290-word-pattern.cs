public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split(' ');
        if(words.Length != pattern.Length) return false;
        var map = new Dictionary<char,string>();
        var used = new HashSet<string>();
        for(int i = 0 ; i < pattern.Length ; i++)
        {
            if(!map.ContainsKey(pattern[i]))
            {
                if(used.Contains(words[i])) return false;
                map.Add(pattern[i] , words[i]);
                used.Add(words[i]);
            }
            else if(map[pattern[i]] != words[i])
            {
                return false;
            }
        }
        return true;
    }
}