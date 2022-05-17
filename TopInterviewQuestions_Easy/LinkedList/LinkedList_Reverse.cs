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
    public ListNode ReverseList(ListNode head) {
        
        ListNode prev = null;
        ListNode next = head;
        
        while (head != null) {
            next = head.next; // save next
            
            head.next = prev; // reverse
            
            prev = head; // set prev = head (curr) for next iteration
            
            head = next; // head = head.next (move along)
        }
        
        return prev;
    }
}