public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int time = 0 ; 
        Queue<int> people = new Queue<int>();
        for(int i = 0 ; i < tickets.Length ; i++)
        {
            people.Enqueue(i);
        }
        while(true)
        {
            int index = people.Dequeue();
            tickets[index]--;
            if(tickets[index] != 0)
                people.Enqueue(index);
            time++;
            if(tickets[k] == 0) break;
        }
        return time;
    }
}