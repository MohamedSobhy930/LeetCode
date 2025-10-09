/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode curA = headA;
        
        while(curA != null)
        {
            ListNode curB = headB;
            while(curB != null)
            {
                if(curA == curB)
                    return curA;
                curB = curB.next;
            }
            curA = curA.next;
        }
        return null;
    }
}