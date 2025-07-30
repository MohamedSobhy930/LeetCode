public class Solution {
    public int Candy(int[] ratings) {
        int[] candies = new int[ratings.Length];
        for(int i = 0 ; i < ratings.Length ; i++)
        {
            candies[i] = 1;
        }
        for(int i = 1 ; i < ratings.Length ; i++)
        {
            if(ratings[i] > ratings[i-1])
                candies[i] = candies[i-1] + 1;
        }
        for(int i = ratings.Length-1 ; i > 0 ; i--)
        {
            if(ratings[i-1] > ratings[i])
                candies[i-1] = Math.Max(candies[i-1], candies[i] + 1);
        }
        return candies.Sum();
    }
}