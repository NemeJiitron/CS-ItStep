using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project2.hm.HM_10
{
    internal class Node<T>
    {
        public T Data;
        public int Priority;
        public Node(T data, int priority)
        {
            Data = data;
            Priority = priority;
        }
        public override string ToString()
        {
            return $"Value: {Data}; Priority: {Priority}";
        }
    }

    internal class PriorityQueue<T>
    {
        private List<Node<T>> nodes;
        public int Count { get { return nodes.Count; } }
        public PriorityQueue()
        {
            nodes = new List<Node<T>>();
        }
        public void Enqueue(T value, int priority)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if(nodes[i].Priority > priority)
                {
                    nodes.Insert(i, new Node<T>(value, priority));
                    return;
                }
            }
            nodes.Add(new Node<T>(value, priority));
        }
        public T Dequeue()
        {
            if (nodes.Count == 0) 
            { 
                throw new Exception("Queue is empty");
            }
            T res = nodes[0].Data;
            nodes.RemoveAt(0);
            return res;
        }
        public T Peek()
        {
            return nodes[0].Data;
        }
        public void Clear()
        {
            nodes.Clear();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Node<T> node in nodes) { sb.Append(node.ToString() + "\n"); }
            return sb.ToString();
        }
    }
}
