public class Solution {
    public int FillCups(int[] amount) {
        var maxHeap = new PriorityQueue<int,int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        int totalAmount = 0;
        foreach(int cups in amount)
        {
            totalAmount += cups;
            if(cups > 0)
                maxHeap.Enqueue(cups , cups);
        }
        int seconds = 0;
        while(totalAmount > 0)
        {
            if(maxHeap.Count >= 2)
            {
                maxHeap.TryDequeue(out int a , out int cupA);
                maxHeap.TryDequeue(out int b , out int cupB);
                totalAmount -= 2;
                if(a > 1)
                    maxHeap.Enqueue(a-1,a-1);
                if(b > 1)
                    maxHeap.Enqueue(b-1,b-1);
            }
            else 
            {
                maxHeap.TryDequeue(out int a , out int cupA);
                totalAmount -= 1;
                if(a > 1)
                    maxHeap.Enqueue(a-1,a-1);
            }
            seconds++;
        }
        return seconds;
    }
}