public class Solution {
    public int CountTriples(int n) {
      int count = 0 ; 
      for(int i = 1 ; i <= n ; i++)
      {
        for(int j = i + 1 ; j <= n ; j++)
        {
            int k = i * i + j * j ; 
            int c = (int)Math.Sqrt(k);
            if(c <= n && c * c == k)
                count += 2;
        }
      }
      return count;
    }
}