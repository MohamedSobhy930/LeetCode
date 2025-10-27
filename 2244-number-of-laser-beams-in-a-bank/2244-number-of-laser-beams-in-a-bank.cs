public class Solution {
    public int NumberOfBeams(string[] bank) {
        int beams = 0;
        int floor = 0;
        for(int i = 0 ; i < bank.Length ; i++)
        {
            int numOfOnes = 0;
            foreach(char c in bank[i])
            {
                if(c == '1')
                    numOfOnes++;
            }
            if(numOfOnes > 0)
            {
                beams += numOfOnes * floor;
                floor = numOfOnes;
            }
        }
        return beams;
    }
}