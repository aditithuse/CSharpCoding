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
    public ListNode DeleteDuplicates(ListNode head) {
        
        if(head==null)
            return head;
        
        ListNode p1=head.next,p2=head;
        while(p2.next!=null){
            if(p1.val==p2.val){
                p1=p1.next;
                p2.next=p1;
            }
            else{
                p1=p1.next;
                p2=p2.next;
            }
        }
        return head;
    }
}
