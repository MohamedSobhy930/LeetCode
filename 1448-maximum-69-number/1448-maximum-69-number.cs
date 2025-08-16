public class Solution {
    public int Maximum69Number(int num)
{
    int count = 0, res = num;
    while (res > 0)
    {
        count++;
        res /= 10;
    }
    res = num;
    while (num > 0)
    {
        int mod = Convert.ToInt32(Math.Pow(10 , count-1));
        int check = num / mod;
        if (check == 6)
        {
            res = res + (3 * mod);
            break;
        }
        num %= mod;
        count--;
    }
    return res;
}
}