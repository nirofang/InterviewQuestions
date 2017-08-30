using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet023_Merge_k_Sorted_Lists
    {
        public static ListNode mergeKLists(List<ListNode> lists)
        {

            //Queue<ListNode, List<ListNode>, cmp> qu;

            //Queue<ListNode> qu = new Queue<ListNode>();

            PriorityQueue<ListNode> qu = new PriorityQueue<ListNode>();

            ListNode resu = new ListNode(0);
            ListNode result = resu;
            for (int i = 0; i < lists.Count; ++i)
            {
                if (lists[i] != null)
                    qu.Enqueue(lists[i], lists[i].val);
            }
            while (qu.Count != 0)
            {
                ListNode temp = qu.Peek();
                qu.Dequeue();
                resu.next = new ListNode(temp.val);
                resu = resu.next;
                temp = temp.next;
                if (temp != null)
                {
                    qu.Enqueue(temp, temp.val);
                }
            }
            return result.next;
        }
        //struct cmp
        //{
        //    public bool operator ()(ListNode t1, ListNode t2)  
        //    {  
        //        return t1.val>t2.val;
        //    }
        //}

        static ListNode mergeTwoLists(ListNode l1, ListNode l2)
        {
            if (null == l1) return l2;
            else if (null == l2) return l1;
            if (l1.val < l2.val)
            {
                l1.next = mergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = mergeTwoLists(l1, l2.next);
                return l2;
            }
        }
        public static ListNode mergeKLists2(List<ListNode> lists)
        {
            if (lists.Count == 0) return null;
            int len = lists.Count;
            while (len > 1)
            {
                for (int i = 0; i < len / 2; ++i)
                {
                    lists[i] = mergeTwoLists(lists[i], lists[len - 1 - i]);
                }
                len = (len + 1) / 2;
            }
            return lists.First();
        }


    }
        
}
