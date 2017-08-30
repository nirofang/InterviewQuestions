using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet083_Remove_Duplicates_from_Sorted_List_II
    {
        public static ListNode deleteDuplicates(ListNode head)
        {
            // 链表为空，或链表只有一个元素 
            if (head == null || head.next == null)
                return head;
            ListNode temp = new ListNode(0);
            // 给链表添加一个空的头结点 
            //temp = (struct ListNode ) malloc(sizeof(struct ListNode));
            temp.next = head;
            // 慢指针，当前最终无重复链表的最后一个元素 
            ListNode pre = temp;
            // 快指针，当前遍历指针 
            ListNode cur = head;
            // 一遍遍历实现 
            while (cur != null)
            {
                // 判断无重复链表的next与cur关系
                // 相等情况，则cur向前移动，继续判断 
                while (cur.next != null && pre.next.val == cur.next.val)
                {
                    cur = cur.next;
                }
                // pre为cur时，将pre向前移动 
                if (pre.next == cur)
                {
                    pre = pre.next;
                }
                // pre不为cur时，则pre的new指向cur的next 
                else
                {
                    pre.next = cur.next;
                }
                cur = cur.next;
            }
            // 返回最终链表的头结点 
            return temp.next;
        }

    }
}
