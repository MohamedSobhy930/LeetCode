public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        int[] result = new int[n];
        Stack<int> calls = new Stack<int>();
        int execTime = 0;
        for(int i = 0 ; i < logs.Count ; i++)
        {
            var log = ParseLog(logs[i]);
            if(log.Status == "start")
            {
                if(calls.Count() == 0)
                    calls.Push(log.Id);
                else
                {
                    int lastExec = calls.Peek();
                    calls.Push(log.Id);
                    result[lastExec] += log.Time - execTime;
                    execTime = log.Time;
                }
            }
            else
            {
                int lastExec = calls.Pop();
                result[lastExec] += log.Time - execTime + 1 ;
                execTime = log.Time + 1;
            }
        }
        return result ;
    }
    public (int Id, string Status, int Time) ParseLog(string log) {
    string[] parts = log.Split(':');
    
    int id = int.Parse(parts[0]);
    string status = parts[1];
    int time = int.Parse(parts[2]);
    
    return (id, status, time);
}
}