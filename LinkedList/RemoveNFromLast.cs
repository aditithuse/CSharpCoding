/*Given a linked list, remove the n-th node from the end of list and return its head.*/
namespace ConsoleApp1.Linked_List
{
    public class RemoveNFromLast
    { 

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return head;

            ListNode slow = new ListNode(0);
            slow.next = head;
            ListNode fast = head;
            int counter = 1;

            while (fast != null)
            {
                if (counter > n)
                {
                    slow = slow == null ? head : slow.next; ;
                }

                fast = fast.next;
                counter += 1;
            }

            if (counter - 1 == n)
                return head.next;

            slow.next = slow.next.next;
            return head;

        }
    }    
}

