public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        if (numerator == 0) return "0";

        StringBuilder result = new StringBuilder();
        if ((numerator < 0) ^ (denominator < 0)) 
            result.Append("-");

        long absN = Math.Abs((long)numerator);
        long absD = Math.Abs((long)denominator);

        result.Append(absN / absD);
        long remainder = absN % absD;

        if (absN % absD == 0) 
            return result.ToString(); 

        result.Append(".");
        Dictionary<long, int> remainderMap = new Dictionary<long, int>();

        while (remainder != 0) {
            if (remainderMap.ContainsKey(remainder)) {
                int startIndex = remainderMap[remainder];
                result.Insert(startIndex, "(");
                result.Append(")");
                break; 
            }
            
            remainderMap.Add(remainder, result.Length);
            remainder *= 10;
            result.Append(remainder / absD);
            remainder %= absD;
        }
        return result.ToString();
    }
}