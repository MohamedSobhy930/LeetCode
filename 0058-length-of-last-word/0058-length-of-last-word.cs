public class Solution {
    public int LengthOfLastWord(string s) {
        int LastWordLength = 0,wordLength = 0, i = 0;
        while(i < s.Length)
        {
            if(s[i] != ' ')
            {
                wordLength++;
                i++;
            }
            else
            {
                LastWordLength = wordLength;
                wordLength = 0;
                while(i < s.Length && s[i] == ' ' ) i++;
            }
        }
        return wordLength > 0 ? wordLength : LastWordLength;
    }
}