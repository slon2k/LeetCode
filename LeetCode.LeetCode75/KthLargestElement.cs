using System.Collections.Generic;

namespace LeetCode.LeetCode75;

public class KthLargestElement
{
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var priorityQueue = new PriorityQueue<int, int>();

            foreach (int x in nums)
            {
                priorityQueue.Enqueue(x, x);

                if (priorityQueue.Count > k)
                {
                    priorityQueue.Dequeue();
                }
            }

            return priorityQueue.Dequeue();

        }


        public int FindKthLargestMinHeap(int[] nums, int k)
        {
            var heap = new MinHeap(nums.Length);

            foreach (int x in nums)
            {
                int min = heap.GetMin();

                if (heap.Count < k)
                {
                    heap.Add(x);

                    continue;
                } 

                if (x > min)
                {
                    heap.ExtractMin();
                    heap.Add(x);
                }
            }

            return heap.GetMin();
        }
    
        public class MaxHeap
        {
            private int[] heap;
            private int size;

            public MaxHeap(int capacity)
            {
                heap = new int[capacity];
                size = 0;
            }

            private int LeftChildIndex(int i) => 2 * i + 1;

            private int LeftChild(int i) => heap[LeftChildIndex(i)];

            private int RightChildIndex(int i) => 2 * i + 2;

            private int RightChild(int i) => heap[RightChildIndex(i)];

            private int ParentIndex(int i) => (i - 1) / 2;

            private int Parent(int i) => heap[ParentIndex(i)];

            private void Swap(int i, int j) => (heap[i], heap[j]) = (heap[j], heap[i]);

            private void HeapifyDown(int i)
            {
                int head = heap[i];

                if (RightChildIndex(i) < size && head < RightChild(i))
                {
                    Swap(i, RightChildIndex(i));
                    HeapifyDown(RightChildIndex(i));
                }

                head = heap[i];
                if (LeftChildIndex(i) < size && head < LeftChild(i))
                {
                    Swap(i, LeftChildIndex(i));
                    HeapifyDown(LeftChildIndex(i));
                }
            }

            private void HeapifyUp(int i)
            {
                while (i > 0 && heap[i] > Parent(i))
                {
                    int parentIndex = ParentIndex(i);
                    Swap(i, parentIndex);
                    i = parentIndex;
                }
            }

            public void Add(int value)
            {
                if (size == heap.Length)
                {
                    throw new InvalidOperationException("The capacity is exceeded");
                }
                heap[size++] = value;
                HeapifyUp(size - 1);
            }

            public int ExtractMax()
            {
                if (size == 0)
                {
                    throw new InvalidOperationException("Heap is empty");
                }

                int max = heap[0];

                heap[0] = heap[size - 1];

                size--;
                
                HeapifyDown(0);

                return max;
            }

            public int Count => size;
        }

        public class MinHeap
        {
            private int[] heap;
            private int size;

            public MinHeap(int capacity)
            {
                heap = new int[capacity];
                size = 0;
            }

            private int LeftChildIndex(int i) => 2 * i + 1;

            private int LeftChild(int i) => heap[LeftChildIndex(i)];

            private int RightChildIndex(int i) => 2 * i + 2;

            private int RightChild(int i) => heap[RightChildIndex(i)];

            private int ParentIndex(int i) => (i - 1) / 2;

            private int Parent(int i) => heap[ParentIndex(i)];

            private void Swap(int i, int j)
            {
                (heap[i], heap[j]) = (heap[j], heap[i]);
            }

            private void HeapifyDown(int i)
            {
                int head = heap[i];

                if (RightChildIndex(i) < size && head > RightChild(i))
                {
                    Swap(i, RightChildIndex(i));
                    HeapifyDown(RightChildIndex(i));
                }

                head = heap[i];
                if (LeftChildIndex(i) < size && head > LeftChild(i))
                {
                    Swap(i, LeftChildIndex(i));
                    HeapifyDown(LeftChildIndex(i));
                }
            }

            private void HeapifyUp(int i)
            {
                while (i > 0 && heap[i] < Parent(i))
                {
                    int parentIndex = ParentIndex(i);
                    Swap(i, parentIndex);
                    i = parentIndex;
                }
            }

            public void Add(int value)
            {
                if (size == heap.Length)
                {
                    throw new InvalidOperationException("The capacity is exceeded");
                }
                heap[size++] = value;
                HeapifyUp(size - 1);
            }

            public int ExtractMin()
            {
                if (size == 0)
                {
                    throw new InvalidOperationException("Heap is empty");
                }

                int min = heap[0];

                heap[0] = heap[size - 1];

                size--;

                HeapifyDown(0);

                return min;
            }

            public int Count => size;

            public int GetMin() => heap[0];
        }

    }
}
