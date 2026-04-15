public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        // if(words[startIndex] == target) return startIndex;
        int n = words.Length;
        int toward = 0;
        int backward = 0;
        int i = startIndex;
        while(words[i++ % n] != target)
        {
            if(i == n + startIndex)
                return -1;
            toward++;
        }
        i = startIndex;
        while(words[(i-- + n) % n] != target)
            backward++;
        return Math.Min(toward , backward);
    }
}