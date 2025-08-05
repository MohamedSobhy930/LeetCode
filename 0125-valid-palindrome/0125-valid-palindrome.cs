public class Solution {
    public bool IsPalindrome(string s) {
        string cleaned = new string (
            s.Where(c => char.IsLetterOrDigit(c))
            .Select(char.ToLower)                  
            .ToArray()
        );
        for(int i = 0, j = cleaned.Length - 1 ; i < cleaned.Length / 2; i++ , j--)
        {
            if(cleaned[i] != cleaned[j]) 
                return false;
        }
        return true;
    }
}