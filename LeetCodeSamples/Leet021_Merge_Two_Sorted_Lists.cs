using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet021_Merge_Two_Sorted_Lists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode newHead;
            if (l1.val < l2.val)
            {
                newHead = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                newHead = new ListNode(l2.val);
                l2 = l2.next;
            }

            ListNode cur = newHead;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }

            while (l1 != null)
            {
                cur.next = l1;
                l1 = l1.next;
                cur = cur.next;
            }

            while (l2 != null)
            {
                cur.next = l2;
                l2 = l2.next;
                cur = cur.next;
            }

            return newHead;
        }
    }
}
