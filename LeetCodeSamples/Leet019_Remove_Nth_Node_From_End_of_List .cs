using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.DataStruct;

namespace LeetCodeSamples
{

    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */

    public class Leet019_Remove_Nth_Node_From_End_of_List
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head != null)
            {
                if (n == 0)
                    return head;
                int step = 0;
                ListNode fast = head;
                while (step < n && fast != null)
                {
                    step++;
                    fast = fast.next;
                }
                if (fast == null)
                {
                    if (step == n)
                        return head.next;
                    else
                        return head;
                }
                ListNode slow = head;
                while (fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                slow.next = slow.next.next;

                return head;
            }
            else
                return null;
        }


        public ListNode RemoveNthFromEnd_Own(ListNode head, int n)
        {
            
            if (head == null)
            {
                return head;
            }
            ListNode pre = new ListNode(0);
            pre.next = head;

            ListNode fast = pre;

            int count = 0;
            while (fast != null && count < n)
            {
                fast = fast.next;
                count++;
            }
            if (fast == null)
            {
                return head;
            }
            ListNode slow = pre;
            while(fast.next!= null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return pre.next;

        }
    }
}
