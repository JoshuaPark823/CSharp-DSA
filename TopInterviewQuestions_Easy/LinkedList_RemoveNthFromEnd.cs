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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        var FastPointer = head;
        var SlowPointer = head;

        for (int i = 0; i < n; i++)
        {
            // This condition will enter if the length of the LL is <= n
            // In this case, shift head to be head.next (null) and return.
            if (FastPointer.next == null)
            {
                head = head.next;
                return head;
            }
            else
            {
                FastPointer = FastPointer.next;
            }
        }

        while (FastPointer.next != null)
        {
            FastPointer = FastPointer.next;
            SlowPointer = SlowPointer.next;
        }

        SlowPointer.next = SlowPointer.next.next;

        return head;
    }
}