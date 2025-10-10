public class Solution {
    public int MaximumEnergy(int[] energy, int k) {
        int maxEnergy = int.MinValue;
        int n = energy.Length;
        for(int i = n - 1 ; i >= 0 ; i--)
        {
            if(i + k < n)
                energy[i] += energy[i+k];
            maxEnergy = Math.Max(maxEnergy,energy[i]);
        }
        return maxEnergy;
    }
}