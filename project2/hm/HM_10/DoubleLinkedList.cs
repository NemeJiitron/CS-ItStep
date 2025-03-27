using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_10
{
    public class DoublyLinkedNode<T>
    {
        public T Data;
        public DoublyLinkedNode<T>? Next;
        public DoublyLinkedNode<T>? Prev;
        public DoublyLinkedNode(T val)
        {
            Data = val;
            Next = null;
            Prev = null;
        }
        public override string ToString()
        {
            return $"{Data} -> ";
        }
    }
    internal class DoublyLinkedList<T>
    {
        private DoublyLinkedNode<T>? Head;
        private DoublyLinkedNode<T>? Tail;
        private int _size;
        public int Count { get { return _size; } }
        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }
        public bool isEmpty()
        {
            return Head == null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            DoublyLinkedNode<T> head = Head;
            while (head != null)
            {
                sb.Append(head.ToString());
                head = head.Next;
            }
            return sb.ToString();
        }
        public void AddLast(T value)
        {
            if (isEmpty())
            {
                DoublyLinkedNode<T> newnode = new(value);
                newnode = Head = Tail;
                _size++;
                return;
            }
            DoublyLinkedNode<T> node = new(value);
            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
            _size++;
        }
        public void AddFirst(T value)
        {
            if (isEmpty())
            {
                DoublyLinkedNode<T> newnode = new(value);
                newnode = Head = Tail;
                _size++;
                return;
            }
            DoublyLinkedNode<T> newNode = new(value);
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
            _size++;
        }
        public void Insert(T value, int index)
        {
            if (index >= _size || index < 0) throw new IndexOutOfRangeException("Out of List range");
            if (index == 0)
            {
                DoublyLinkedNode<T> Node = new(value);
                Node.Next = Head;
                Head = Node;
                _size++;
                return;
            }
            DoublyLinkedNode<T> curNode = Head;
            int i = 0;
            while (i != index - 1)
            {
                curNode = curNode.Next;
                i++;
            }
            DoublyLinkedNode<T>? node = curNode.Next;
            curNode.Next = new(value);
            curNode.Next.Next = node;
            _size++;
        }
        public void RemoveAt(int index)
        {
            if (isEmpty()) return;
            if (index > _size || index < 0) throw new IndexOutOfRangeException("Out of List range");
            if (index == 0)
            {
                Head = Head.Next;
                _size--;
                return;
            }
            DoublyLinkedNode<T> node = Head;
            int i = 0;
            while (i != index - 1)
            {
                node = node.Next;
                i++;
            }
            if (node.Next != null)
            {
                node.Next = node.Next.Next;
                _size--;
            }
        }
        public T At(int index)
        {
            if (isEmpty()) throw new NullReferenceException("List empty");
            if (index >= _size || index < 0) throw new IndexOutOfRangeException("Out of List range");
            if (index == 0)
            {
                return Head.Data;
            }
            DoublyLinkedNode<T> node = Head;
            int i = 0;
            while (i != index)
            {
                node = node.Next;
                i++;
            }
            return node.Data;
        }
        public void Clear()
        {
            while (Head != null)
            {
                RemoveAt(0);
            }
        }
    }
}
