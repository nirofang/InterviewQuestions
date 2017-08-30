using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSampleCode.Data
{
    #region 最小堆
    public class HeapMin
    {
        public class Node
        {
            public int key;//权
            public int treeindex;
            public Node(int Key, int Index)
            {
                key = Key;
                treeindex = Index;
            }
        };

        private Node[] heap;//存储树组
        private int CurrentSize;//当前元素个数
        private int MaxHeapSize;//最大允许存储个数
                                /// <summary>
                                /// 构造函数
                                /// </summary>
                                /// <param name="MaxSize"></param>
        public HeapMin(int MaxSize)
        {
            heap = new Node[MaxSize];
            MaxHeapSize = MaxSize;
            CurrentSize = 0;
        }
        /// <summary>
        /// 判断是否最小堆满
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            if (CurrentSize == MaxHeapSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 判断是否空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (CurrentSize == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 堆向下调整的算法
        /// </summary>
        /// <param name="start">起始位置</param>
        /// <param name="EndOfHeap">目标位置</param>
        public void FilerDown(int start, int EndOfHeap)
        {
            int i = start, j = 2 * i + 1;
            Node temp = heap[i];
            while (j <= EndOfHeap)
            {
                if (j < EndOfHeap && heap[j].key > heap[j + 1].key) j++;
                if (temp.key <= heap[j].key) break;
                else
                {
                    heap[i] = heap[j];
                    i = j;
                    j = 2 * j + 1;
                }
            }
            heap[i] = temp;
        }
        /// <summary>
        ///堆向上调整的算法
        /// </summary>
        /// <param name="start"></param>
        public void FilerUp(int start)
        {
            int j = start, i = (j - 1) / 2;
            Node temp = heap[j];
            while (j > 0)
            {
                if (heap[i].key <= temp.key) break;
                else
                {
                    heap[j] = heap[i];
                    j = i;
                    i = (i - 1) / 2;
                }
            }
            heap[j] = temp;
        }
        /// <summary>
        /// Insert Node
        /// </summary>
        /// <param name="node"></param>
        public int Insert(Node node)
        {
            if (CurrentSize == MaxHeapSize) return 0;
            heap[CurrentSize] = node;
            FilerUp(CurrentSize);
            CurrentSize++;
            return 1;
        }
        /// <summary>
        /// Remove and Return Min Node index
        /// </summary>
        /// <returns>Node Type</returns>
        public int RemoveMin()
        {
            Node temp;
            if (CurrentSize == 0)
            {
                return -1;
            }
            else
            {
                temp = heap[0];
                heap[0] = heap[CurrentSize - 1];
                CurrentSize--;
                FilerDown(0, CurrentSize - 1);
                return temp.treeindex;
            }
        }
        /// <summary>
        /// 清空
        /// </summary>
        public void MakeEmpty()
        {
            CurrentSize = 0;
        }
    }
    #endregion
}
