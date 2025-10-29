public class Solution {
    public int SmallestNumber(int n) {
        string s = Convert.ToString(n , 2);
    return (int)Math.Pow(2, s.Length) -1 ;
    }
}