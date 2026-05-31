public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        Array.Sort(asteroids);
        long eatenMass = mass;
        for(int i = 0 ; i < asteroids.Length ; i++)
        {
            if(asteroids[i] > eatenMass) return false;
            eatenMass += asteroids[i];
        }
        return true;
    }
}