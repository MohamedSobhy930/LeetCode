public class Solution {
    public int BinaryGap(int n) {
        string binaryN = Convert.ToString(n , 2);
        int length = binaryN.Length;
        int longestDistance = 0;
        int lastSeen = -1;
        for(int i = 0 ; i < length ; i++)
        {
            if(binaryN[i] == '1')
            {
                if(lastSeen != -1)
                {
                    longestDistance = Math.Max(longestDistance , i - lastSeen);
                }
                lastSeen = i;
            }
        }
        return longestDistance;
    }
}