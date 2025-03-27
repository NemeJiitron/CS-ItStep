using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_10
{
    public class LinkedNode<T>
    {
        public T Data;
        public LinkedNode<T>? Next;
        public LinkedNode(T val)
        {
            Data = val;
            Next = null;
        }
        public override string ToString()
        {
            return $"{Data} -> ";
        }
    }
    internal class LinkedList<T>
    {
        private LinkedNode<T>? Head;
        private int _size;
        public int Count { get { return _size;  } }
        public LinkedList()
        {
            Head = null;
        }
        public bool isEmpty()
        {
            return Head == null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            LinkedNode<T> head = Head;
            while (head != null)
            {
                sb.Append(head.ToString());
                head = head.Next;
            }
            return sb.ToString();
        }
        public void Add(T value)
        {
            if (isEmpty())
            {
                Head = new LinkedNode<T>(value);
                _size++;
                return;
            }
            LinkedNode<T> node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new LinkedNode<T>(value);
            _size++;
        }
        public void AddFirst(T value)
        {
            if (isEmpty())
            {
                Head = new LinkedNode<T>(value);
                _size++;
                return;
            }
            LinkedNode<T> newNode = new(value);
            newNode.Next = Head;
            Head = newNode;
            _size++;
        }
        public void Insert(T value, int index)
        {
            if (index >= _size || index < 0) throw new IndexOutOfRangeException("Out of List range");
            if (index == 0)
            {
                LinkedNode<T> Node = new(value);
                Node.Next = Head;
                Head = Node;
                _size++;
                return;
            }
            LinkedNode<T> curNode = Head;
            int i = 0;
            while (i != index - 1)
            {
                curNode = curNode.Next;
                i++;
            }
            LinkedNode<T>? node = curNode.Next;
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
            LinkedNode<T> node = Head;
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
            LinkedNode<T> node = Head;
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
