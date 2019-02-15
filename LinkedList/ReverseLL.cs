/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        if(head==null)
            return head;
        
        if(head.next == null)
            return head;
               
        ListNode prev = null, curr = head;
        
        while(curr != null){
            ListNode next = curr.next;
            curr.next = prev;
            prev=curr;            
            curr= next;        
        }
        
        return prev;
    }
}
