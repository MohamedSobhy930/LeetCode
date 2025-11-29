public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> studentsQueue= new Queue<int>();
        for(int i = 0 ; i < students.Length ; i++)
        {
            studentsQueue.Enqueue(students[i]);
        }
        int studentsLeft = 0;
        int j = 0;
        while(studentsQueue.Count > 0 && studentsLeft < studentsQueue.Count)
        {
            if(studentsQueue.Peek() == sandwiches[j])
            {
                studentsQueue.Dequeue();
                j++;
                studentsLeft = 0;
            }
            else
            {
                studentsQueue.Enqueue(studentsQueue.Dequeue());
                studentsLeft++;
            }
        }
        return studentsLeft;
    }
}