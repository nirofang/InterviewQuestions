using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }

     }

    public class Leet001_Add_Two_Numbers
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            if (l1 != null && l2 != null)

            {

                int carry = 0;

                int num = 0;

                int n = 0;

                ListNode newHead = null;

                ListNode last = newHead;

                while (l1 != null && l2 != null)

                {

                    num = (l1.val + l2.val + carry);

                    n = num % 10;

                    carry = num / 10;

                    if (newHead == null)

                    {

                        newHead = new ListNode(n);

                        last = newHead;

                    }

                    else

                    {

                        ListNode newNode = new ListNode(n);

                        last.next = newNode;

                        last = last.next;

                    }

                    l1 = l1.next;

                    l2 = l2.next;

                }

                ListNode l = l1 == null ? l2 : l1;



                while (l != null)

                {

                    num = l.val + carry;

                    n = num % 10;

                    carry = num / 10;

                    ListNode newNode = new ListNode(n);

                    last.next = newNode;

                    last = last.next;

                    l = l.next;

                }



                if (carry > 0)

                {

                    ListNode newNode = new ListNode(carry);

                    last.next = newNode;

                    last = last.next;

                }



                return newHead;

            }

            else

            {

                if (l1 == null)

                    return l2;

                else

                    return l1;

            }

        }

    }
}
