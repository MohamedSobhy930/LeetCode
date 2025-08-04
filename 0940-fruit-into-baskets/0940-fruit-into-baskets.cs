public class Solution {
    public int TotalFruit(int[] fruits) {
        int collectedFruits = 0, l = 0;
        Dictionary<int,int> exists = new Dictionary<int,int>();
        for(int i = 0 ; i < fruits.Length ; i++)
        {
            if(!exists.ContainsKey(fruits[i]))
                exists[fruits[i]] = 0;
            exists[fruits[i]]++;

            while(exists.Count > 2)
            {
               exists[fruits[l]]--;
               if(exists[fruits[l]] == 0)
                    exists.Remove(fruits[l]);
                l++;
            }
            collectedFruits = Math.Max(collectedFruits, i-l+1);
        }
        return collectedFruits;
    }
}