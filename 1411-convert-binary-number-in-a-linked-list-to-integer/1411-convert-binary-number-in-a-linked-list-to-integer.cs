/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        ListNode cur = head;
        int count = 0, result = 0;
        while(cur != null)
        {
            count++;
            cur = cur.next;
        }
        cur = head;
        while(count > 0)
        {
            result += cur.val * Convert.ToInt32(Math.Pow(2, count-1));
            cur = cur.next;
            count--;
        }
        return result;
    }
}