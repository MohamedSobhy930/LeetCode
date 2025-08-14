public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> charFreq = new Dictionary<char,int>();
        foreach(char c in magazine)
        {
            if(!charFreq.ContainsKey(c))
                charFreq[c] = 0 ;
            charFreq[c]++;
        }
        for(int i = 0 ; i < ransomNote.Length ; i++)
        {
            if(!charFreq.ContainsKey(ransomNote[i]))
            {
                return false;
            }
            else
            {
                charFreq[ransomNote[i]]--;
            }
            if(charFreq[ransomNote[i]] == 0)
            {
                charFreq.Remove(ransomNote[i]);
            }
        }
        return true;
    }
}