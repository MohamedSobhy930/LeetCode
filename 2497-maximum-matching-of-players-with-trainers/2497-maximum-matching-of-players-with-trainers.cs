public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
       Array.Sort(trainers);
       Array.Sort(players);
       int matching = 0, i = 0, j =0;
       while(j < trainers.Length && i < players.Length)
       {
        if(players[i] <= trainers[j])
        {
            matching++;
            i++;
            j++;
        }
        else
        {
            j++;
        }
       } 
       return matching;
    }
}