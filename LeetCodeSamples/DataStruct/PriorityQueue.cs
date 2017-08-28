using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeetCodeSamples.DataStruct
{
    public class PriorityQueue<T>
    {
        SortedDictionary<int, Queue<T>> storage;

        public PriorityQueue()
        {
            storage = new SortedDictionary<int, Queue<T>>();
        }

        public bool IsEmpty()
        {
            return (Count == 0);
        }

        public int Count
        {
            get;
            private set;
        }

        public void Enqueue(T item, int prio)
        {
            if (!storage.ContainsKey(prio))
            {
                storage.Add(prio, new Queue<T>());
            }

            storage[prio].Enqueue(item);
            Count++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            else
            {
                var firstQueue = GetFirstQueue();
                T elem = firstQueue.Dequeue();
                RemoveFirstQueueIfEmpty();
                Count--;
                return elem;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
                return default(T);
            else
            {
                var firstQueue = GetFirstQueue();
                return firstQueue.Peek();
            }
        }

        private Queue<T> GetFirstQueue()
        {
            var enumerator = storage.GetEnumerator();
            enumerator.MoveNext();
            return enumerator.Current.Value;
        }

        private void RemoveFirstQueueIfEmpty()
        {
            var enumerator = storage.GetEnumerator();
            enumerator.MoveNext();
            if (enumerator.Current.Value.Count == 0)
            {
                storage.Remove(enumerator.Current.Key);
            }
        }
    }
}
