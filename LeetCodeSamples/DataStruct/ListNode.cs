using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.DataStruct
{
    // definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public ListNode(int[] vs)
        {
            ListNode prev = new ListNode(0);

            int index = 0;

            foreach (int v in vs)
            {

                if (index == 0)
                {
                    this.val = v;
                    prev = this;
                }
                else
                {
                    ListNode tmp = new ListNode(v);
                    prev.next = tmp;
                    prev = tmp;
                }
                index++;
            }
        }

        public void AddTail(ListNode listNode)
        {
            ListNode tail = this;

            while (tail.next != null)
            {
                tail = tail.next;
            }
            tail.next = listNode;

        }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            ListNode p = (ListNode)obj;
            ListNode k = this;

            while (p.next != null && k.next != null)
            {
                p = p.next;
                k = k.next;

                if (p.val != k.val)
                {
                    return false;
                }
            }
            if (p.next != null || k.next != null)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return val;
        }
    }

}

