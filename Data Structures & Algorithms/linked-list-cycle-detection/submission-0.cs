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
    public bool HasCycle(ListNode head) 
    {
        // ListNode dummy = new ListNode(0);
        // ListNode tail = dummy;
        HashSet<ListNode> repeats = new HashSet<ListNode>();

        while (head != null)
        {
            if (repeats.Contains(head))
            {
               return true;
            }
            

            repeats.Add(head); 
            head = head.next;
        }
    
        return false;
    }
}
