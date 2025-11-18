public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int n = bits.Length ;
        int character = 1;
        for(int i = 0 ; i < n ; i++)
        {
            if(bits[i] == 0)
                character = 1;
            else
            {
                i++;
                character = 2;
            }
        }
        return character ==1;
    }
}