using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamplesTests
{
    public class Leet025_Reverse_Nodes_in_k_Group
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || head.next == null || k < 0)
            {
                return head;
            }

            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode pre = dummy;
            ListNode cur = head;

            while(cur != null)
            {
                ListNode p = pre.next; //ListNode p = cur;

                int group = k;

                while(p != null && group > 0)
                {
                    group--;
                    p = p.next;
                }
                if (group > 0)  //end of list
                {
                    break;
                }
                while(cur.next != p)
                {
                    ListNode nt = cur.next.next;
                    cur.next.next = pre.next;
                    pre.next = cur.next;
                    cur.next = nt;
                }

                pre = cur;
                cur = cur.next;

            }

            return dummy.next;
        }
    }
}
