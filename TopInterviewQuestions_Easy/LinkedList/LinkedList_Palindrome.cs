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
    public bool IsPalindrome(ListNode head) {
        
        List<ListNode> nodes = new List<ListNode>();
        
        while (head != null)
        {
            nodes.Add(head);
            head = head.next;
        }

        for (int i = 0, j = nodes.Count - 1; i < j; i++, j--) 
        {
            // Found two differing values
            if (nodes[i].val != nodes[j].val) 
            {
                return false;
            }
        }
        
        return true;
    }
}