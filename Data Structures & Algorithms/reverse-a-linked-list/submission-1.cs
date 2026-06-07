public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null;
        ListNode current = head;
        while(current != null){
            ListNode nextNode = current.next;
            current.next = previous;

            previous = current;
            current = nextNode;

        }
        return previous;
    }
}