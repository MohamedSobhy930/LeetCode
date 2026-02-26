public class Solution {
    public int NumSteps(string s) {
        int steps = 0;
        int carry = 0;
        int n = s.Length ;
        for(int i = n -1; i > 0 ; i--)
        {
            if(s[i] == '1')
            {
                if(carry == 0)
                {
                    steps += 2;
                    carry = 1;
                }
                else 
                {
                    steps++;
                }
                
            }
            else if(s[i] == '0' && carry == 1)
            {
                steps += 2;
            }
            else
            {
                steps++;
            }
        }
        if(carry == 1) steps++;
        return steps;
    }
}