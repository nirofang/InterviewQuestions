using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet109_Covert_Sorted_List_to_Binary_Search_Tree
    {
        public static TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return new TreeNode(head.val); ;
            }

            ListNode mid = FindMid(head);
            TreeNode root = new TreeNode(mid.val);
            root.left = SortedListToBST(head);
            root.right = SortedListToBST(mid.next);

            return root;
        }

        static ListNode FindMid(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;
            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = null;
            return slow;
        }
    }
}
