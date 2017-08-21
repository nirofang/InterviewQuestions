using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet024_Swap_Nodes_in_Pairs
    {
        public ListNode swapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode cur = dummy;

            while(cur != null && cur.next!=null && cur.next.next !=null)
            {
                cur.next = swap(cur.next, cur.next.next);
                cur = cur.next.next;
            }
            return dummy.next;
        }

        private ListNode swap(ListNode next1, ListNode next2)
        {
            next1.next = next2.next;
            next2.next = next1;

            return next2;
        }
    }
}
