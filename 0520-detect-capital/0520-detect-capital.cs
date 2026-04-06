public class Solution {
    public bool DetectCapitalUse(string word) {
       int capitals = 0;
       for(int i = 0 ; i < word.Length ; i++)
       {
            if(word[i] < 'a')
            {
                if(i > 0 && capitals ==0)
                    return false;
                capitals++;
            }
       } 
       return capitals <= 1 || capitals == word.Length;
    }
}