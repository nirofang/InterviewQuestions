using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet061_Rotate_List
    {
        public static ListNode rotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }
            if (k == 0)
            {
                return head;
            }
            int len = 0;
            ListNode phead = new ListNode(0);
            phead.next = head;
            ListNode p = head;
            int flag = 0;
            ListNode end = null;
            while (p != null)
            {
                len++;
                if (p.next == null)
                {
                    end = p;
                }
                p = p.next;
            }
            if (k == len)
            {
                return head;
            }
            if (k > len)
            {
                k = k % len;
            }
            p = phead;
            while (flag < len - k)
            {
                flag++;
                p = p.next;
            }
            end.next = phead.next;
            phead.next = p.next;
            p.next = null;

            return phead.next;
        }
    }
}
