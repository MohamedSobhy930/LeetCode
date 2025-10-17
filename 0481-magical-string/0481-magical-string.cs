public class Solution {
    public int MagicalString(int n) {
        if(n <= 3) return 1;

        List<char> result = new List<char>(){'1','2','2'};
        int read = 2;
        char charToWrite = '1';

        while(result.Count < n)
        {
            int count = result[read] - '0';
            for(int i = 0 ; i < count ; i++)
                result.Add(charToWrite);

            charToWrite = charToWrite == '1' ? '2' : '1' ;
            read++;
        }
        int numOfOnes = 0;
        for(int i = 0 ; i < n ; i++)
        {
            if(result[i] == '1')
                numOfOnes++;
        }
        return numOfOnes;
    }
}