using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet086_Partition_List
    {
        public static ListNode partition(ListNode head, int x)
        {
            // 空链表处理 
            if (head == null)
                return null;
            // 定义两个新链表的表头head1和head2 
            //struct ListNode head1 = (struct ListNode ) malloc(sizeof(struct ListNode));
            //struct ListNode head2 = (struct ListNode ) malloc(sizeof(struct ListNode));
            ListNode head1 = new ListNode(0);
            ListNode head2 = new ListNode(0);

            //struct ListNode p1 = head1;
            //struct ListNode p2 = head2;

            ListNode p1 = head1;
            ListNode p2 = head2;
            // 一遍遍历整个链表 
            while (head != null)
            {
                // 当前节点值小于x，则将当前节点挂接在head1的尾端 
                if (head.val < x)
                {
                    p1.next = head;
                    p1 = head;
                    head = head.next;
                }
                // 当前节点大于等于x，则将当前节点挂接在head2的尾端 
                else
                {
                    p2.next = head;
                    p2 = head;
                    head = head.next;
                }
            }
            // 将head2的尾指针指向null 
            p2.next = null;
            // 将链表head1尾端与链表head2的头部相接 
            p1.next = head2.next;
            // 返回最终的链表 
            return head1.next;
        }
    }
}
