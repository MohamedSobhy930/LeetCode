public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int unplaced = fruits.Length;
        for(int i = 0; i < fruits.Length; i++)
        {
            for(int j = 0; j < baskets.Length; j++)
            {
                if(fruits[i] <= baskets[j])
                {
                    baskets[j] = -1;
                    unplaced--;
                    break ;
                }
            }
        }
        return unplaced;
    }
}