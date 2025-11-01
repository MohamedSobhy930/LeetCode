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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        var map =new HashSet<int>(nums);
        ListNode dummy = new ListNode(0,head);
        ListNode curr = dummy;
        while(curr.next != null)
        {
            if(map.Contains(curr.next.val))
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr = curr.next;
            }
        }
        return dummy.next;
    }
}