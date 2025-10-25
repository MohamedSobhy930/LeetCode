public class Solution {
    public int TotalMoney(int n)
{
    if (n <= 7) return n * (n + 1) / 2;
    int sum = 28;
    int weeks = n / 7;
    for (int i = 2; i <= weeks; i++)
    {
        int weakSum = 7 * i + 21;
        sum += weakSum;
    }
    n %= 7;
    weeks++;
    for(int i = 0; i < n; i++)
    {
        sum += weeks;
        weeks++;
    }
    return sum;
}
}