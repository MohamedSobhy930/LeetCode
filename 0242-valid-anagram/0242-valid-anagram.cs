public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var map = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(!map.ContainsKey(c))
            {
                map[c] = 0;
            }
            map[c]++;
        }
        for(int i = 0 ; i < t.Length ; i++)
        {
            if(map.ContainsKey(t[i]))
            {
                map[t[i]]--;
                if(map[t[i]] == 0)
                    map.Remove(t[i]);
            }
            else 
                return false;
            
        }
        return true;
    }
}