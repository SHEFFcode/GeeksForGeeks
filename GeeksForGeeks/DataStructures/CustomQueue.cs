using System;
namespace GeeksForGeeks.DataStructures
{
    public class CustomQueue
    {
        int front, rear, size;
        int capacity;
        int[] container;

        public CustomQueue(int capacity)
        {
            this.capacity = capacity;
            front = 0;
            rear = capacity - 1;
            container = new int[this.capacity];
        }

        public bool IsFull()
        {
            return size == capacity;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                return;
            }
            rear = (rear + 1) % capacity; // this is to enable circular front and rear
            container[rear] = item; // put the item at the end of the queue
            size++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                return -1;
            }
            var item = container[front];
            front = (front + 1) % capacity; // again resets to 0 when reaches capacity
            size--;
            return item;
        }

        public int Front()
        {
            return IsEmpty() ? -1 : container[front];
        }

        public int Rear()
        {
            return IsEmpty() ? -1 : container[rear];
        }
    }
}
