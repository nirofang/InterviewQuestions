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



    public class Leet002_Add_Two_Numbers
    {
        public ListNode Add_Two_Numbers(ListNode l1, ListNode l2)
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


        public ListNode Add_Two_Numbers_Own(ListNode l1, ListNode l2)
        {
            int carry = 0;
            int sum = 0;
            ListNode head = null;
            ListNode prev = null;

            while (l1 != null || l2 != null)
            {
                if (l1!=null)
                {
                    sum += l1.val;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                }

                sum += carry;
                carry = sum / 10;

                sum = sum % 10;

                if (head == null)
                {
                    head = new ListNode(sum);
                    prev = head;
                }
                else
                {
                    prev.next = new ListNode(sum);
                    prev = prev.next;
                }
                l1 = l1.next;
                l2 = l2.next;
            }

            ListNode l = (l1 == null) ? l2 : l1;

            while (l != null)
            {
                sum = l.val + carry;
                carry = sum / 10;
                sum = sum % 10;
                prev.next = new ListNode(sum);
                prev = prev.next;
            }

            if (carry == 1)
            {
                prev.next = new ListNode(1);
            }

            return head;
        }

    }
}
