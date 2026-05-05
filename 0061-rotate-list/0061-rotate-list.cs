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
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null || head.next == null) return head;
        int count = 0;
        ListNode cur = head;
        while(cur != null && cur.next != null)
        {
            cur = cur.next;
            count++;
        }
        ListNode lastNode = cur;
        k = k % (count + 1);
        if(k == 0) return head;
        cur = head;
        int remaining = count - k;
        while(remaining > 0)
        {
            cur = cur.next;
            remaining--;
        }
        ListNode newHead = cur.next;
        cur.next = null;
        lastNode.next = head;
        head = newHead;
        return head;
    }
}