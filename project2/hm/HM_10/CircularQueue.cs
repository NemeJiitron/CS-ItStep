using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_10
{
    internal class CircularQueue<T>
    {
        T[] array;
        int size = 0;
        int capacity;
        int front = -1;
        int rear = -1;
        public bool IsFull()
        {
            return size == capacity;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        public CircularQueue(int capacity)
        {
            array = new T[capacity];
            this.capacity = capacity;
        }
        public void Enqueue(T item)
        {
            if (IsFull())
            {
                throw new Exception("Queue is full");
            }
            if (IsEmpty())
            {
                front = 0;
            }
            rear = rear + 1;
            if (rear == capacity)
            {
                rear = 0;
            }
            array[rear] = item;
            size++;
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            T res = array[front];
            front = front + 1;
            if (front == capacity)
            {
                front = 0;
            }
            size--;
            return res;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            return array[front];
        }

    }
}
