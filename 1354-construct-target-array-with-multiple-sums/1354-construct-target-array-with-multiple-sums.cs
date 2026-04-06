public class Solution {
    public bool IsPossible(int[] target) {
        long totalSum = 0;
        var maxHeap = new PriorityQueue<int,int>();
        foreach(int num in target)
        {
            totalSum += num;
            maxHeap.Enqueue(num , -num);
        }
        while(maxHeap.Peek() > 1)
        {
            int max = maxHeap.Dequeue();
            long restSum = totalSum - max;

            if(restSum == 1) return true;
            if(restSum == 0) return false;
            if(restSum >= max) return false;

            int replaced = (int)(max % restSum) ; 
            if(replaced == 0) return false;

            maxHeap.Enqueue(replaced , -replaced);
            totalSum = restSum + replaced;
        }
        return true;
    }
}