public class Solution {
    public int FillCups(int[] amount) {
        var maxHeap = new PriorityQueue<int,int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach(int cups in amount)
        {
            if(cups > 0)
                maxHeap.Enqueue(cups , cups);
        }
        int seconds = 0;
        while(maxHeap.Count > 1)
        {
            int first = maxHeap.Dequeue();
            int second = maxHeap.Dequeue();

            seconds++;
            if(first > 1)
                maxHeap.Enqueue(first-1,first-1);
            if(second > 1)
                maxHeap.Enqueue(second-1,second-1);
        }
        if(maxHeap.Count == 1)
        {
            seconds += maxHeap.Dequeue();
        }
        return seconds;
    }
}