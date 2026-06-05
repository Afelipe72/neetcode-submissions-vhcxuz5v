public class Solution {
    public ListNode ReverseList(ListNode head) {

        ListNode previous = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode nextNode = current.next; // save where we're going

            current.next = previous;         // flip arrow

            previous = current;              // move previous forward
            current = nextNode;              // move current forward
        }

        return previous;
    }
}