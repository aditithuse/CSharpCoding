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
    public ListNode MiddleNode(ListNode head) {
        ListNode p1 = head;
        ListNode p2=head;
        while(p2!=null && p2.next!=null){
            p2=p2.next.next;
            p1=p1.next;
        }
        
        return p1;
    }
}
