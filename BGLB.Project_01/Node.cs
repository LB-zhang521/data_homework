using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGLB.Project_01
{
    public class Node<T>
    {
        private T data;//泛型

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        private Node<T> next;//node型

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }
        public Node(Node<T> p)
        {
            next = p;
        }
        public Node(T val)
        {
            data = val;
            next = null;
        }
        public Node()
        {
            data = default(T);
            next = null;

        }

    }
}
