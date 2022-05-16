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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        // If a list is empty, return the other
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        
        ListNode head = new ListNode(); // Reference to the head
        ListNode tail = head;           // Reference to the tail
        
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            
            tail = tail.next;
        }
        
        // If the lists were unequal length, append the remaining list
        
        if (list1 == null)
            tail.next = list2;
        
        if (list2 == null)
            tail.next = list1;
        
        return head.next;
        
    }
}