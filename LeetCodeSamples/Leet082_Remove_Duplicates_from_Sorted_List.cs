using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet082_Remove_Duplicates_from_Sorted_List
    {
        public static ListNode deleteDuplicates(ListNode head)
        {
            // 空链表或只有一个元素链表 
            if (head == null || head.next == null)
                return head;
            // 慢指针 
            //struct ListNode *q = head;
            ListNode q = head;
            // 快指针 
            //struct ListNode *p = head->next; 
            ListNode p = head.next;
            // 一遍遍历 
            while (p != null)
            {
                if (q.val == p.val)
                {
                    // 跳过快指针 
                    q.next = p.next;
                    // 快指针前移 
                    p = p.next;
                }
                else
                {
                    // 两个指针同时前移 
                    p = p.next;
                    q = q.next;
                }
            }
            // 返回链表头结点 
            return head;
        }

    }
}
