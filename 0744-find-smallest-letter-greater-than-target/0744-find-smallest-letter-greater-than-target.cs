public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int n = letters.Length ;
        if(target >= letters[n-1]) return letters[0];
        for(int i = 0 ; i < n ; i++)
        {
            if(letters[i] > target)
                return letters[i];
        }
        return letters[n-1];
    }
}