public class Solution {
    public bool IsValid(string word) {
       if(word.Length < 3) return false;
       int count = 0,vowelCount = 0,constCount = 0;
       HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
       for(int i = 0; i < word.Length; i++)
       {
        if(Char.IsDigit(word[i])) 
        {
            count++;
        }
        else if(Char.IsLetter(word[i]))
        {
            if(vowels.Contains(word[i]))
            {
                count++;
                vowelCount++;
            }
            else
            {
                count++;
                constCount++;
            }
        }
       } 
       if(count == word.Length && vowelCount > 0 && constCount > 0)
            return true;
        return false;
    }
}