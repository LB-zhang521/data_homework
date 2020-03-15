using System;

namespace BGLB.Project_01
{
    public class Node<T>
    {
        private T data;                        //请先完成节点Node类的定义，每一个数据元素包括数据data，和节点node引用，两部分。
        private Node<T> next;
        public T Data { get { return data; } set { data = value; } }
        public Node<T> Next { get { return next; } set { next = value; } }

        public Node()
        {
        }
        /// <summary>
        /// 带参数的初始化
        /// </summary>
        /// <param name="item"></param>
        public Node(T item)
        {
            data = item;
            next = null;
        }
    }

    public class LinkList<T>  //链表类
    {
        private Node<T> head;
        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        /// <summary>
        /// 初始化 不带头元素的 单链表
        /// </summary>
        public LinkList()
        {
            head = new Node<T>();
        }
        public LinkList(T[] arr, int j = 0)
        {
            head = new Node<T>();
            head = new Node<T>();
            for (int i = j; i < arr.Length; i++)
            {
                this.Append(arr[i]);
            }
        }
        /// <summary>
        /// 判断链表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }
        /// <summary>
        /// 链表尾插
        /// </summary>
        /// <param name="item">数据</param>
        /// <param name="i">元素节点</param>
        public void InsertPost(T item, int i)   //在第i个元素之后插入item
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null || i <= 0 || i > GetLength())
            {
                System.Console.WriteLine("检查链表是否为空并且确保参数大于0并且小于链表的长度");
            }
            else
            {
                Node<T> temp = head;
                for (int j = 0; j < i; j++)
                {
                    temp = temp.Next;
                }
                Node<T> p = temp.Next;
                temp.Next = newNode;
                newNode.Next = p;
            }
        }
        /// <summary>
        /// 链表头插
        /// </summary>
        /// <param name="item">数据</param>
        /// <param name="i">元素节点</param>
        public void Insert(T item, int i)   //在第i个位置插入item ，相当于在第i个元素之前插入 
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null || i <= 0 || i > GetLength())
            {
                System.Console.WriteLine("检查链表是否为空并且确保参数大于0并且小于链表的长度");
            }
            else
            {
                if (i == 1)
                {
                    Node<T> p = head.Next;
                    head = newNode;
                    newNode.Next = p;
                }
                else
                {
                    Node<T> temp = head;
                    for (int j = 1; j < i; j++)
                    {
                        temp = temp.Next;
                    }
                    Node<T> p = temp.Next;
                    temp.Next = newNode;
                    newNode.Next = p;
                }

            }
        }
        /// <summary>
        /// 链表删除
        /// </summary>
        /// <param name="i">元素节点</param>
        /// <returns></returns>
        public T Delete(int i)   //删除第i个元素
        {
            T ret = default(T);
            if (head == null || i <= 0 || i > GetLength())
            {
                System.Console.WriteLine("检查链表是否为空并且确保参数大于0并且小于链表的长度");
                return ret;
            }
            else
            {
                if (i == 1)
                {
                    ret = head.Next.Data;
                    head.Next = head.Next.Next;
                }
                else
                {
                    Node<T> temp = head.Next;
                    for (int j = 1; j < i - 1; j++)
                    {
                        temp = temp.Next;
                    }
                    ret = temp.Next.Data;
                    Node<T> p = temp.Next.Next;
                    temp.Next = p;
                }
                return ret;
            }
        }
        /// <summary>
        /// 获取元素个数 
        /// </summary>
        /// <returns></returns>
        public int GetLength()  //求链表长度
        {
            int ret = 0;
            if (head != null)
            {
                Node<T> temp = head.Next;
                while (true)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                        ret++;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            return ret;
        }
        /// <summary>
        /// 单链表逆置
        /// </summary>
        public void ReversLinkList()  //就地逆置
        {
            Node<T> p = head.Next;
            Node<T> q = new Node<T>();
            head.Next = null;
            while (p != null)
            {
                q = p;
                p = p.Next;
                q.Next = head.Next;
                head.Next = q;
            }
        }
        /// <summary>
        /// 表尾追加元素
        /// </summary>
        /// <param name="item"></param>
        public void Append(T item)   //表尾追加
        {
            Node<T> newNode = new Node<T>(item);
            if (head.Next == null)
            {
                head.Next = newNode;
            }
            else
            {
                Node<T> temp = head.Next;
                while (true)
                {
                    if (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                temp.Next = newNode;
            }
        }
        /// <summary>
        /// 清空链表
        /// </summary>
        public void Clear()   //清除所有元素
        {
            head = null;
        }
        /// <summary>
        /// 链表的遍历输出
        /// </summary>
        /// <param name="linkList"></param>
        public void Display()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("链表为空");
                return;
            }

            Node<T> A = this.head.Next;
            while (A != null)
            {
                Console.Write(A.Data + "\t");
                A = A.Next;
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 两个链表首尾合并 有重复項 会更改链表1
        /// </summary>
        /// <param name="linkList1">第一个链表</param>
        /// <param name="linkList2">第二个链表</param>
        public LinkList<T> Merge1(LinkList<T> linkList1, LinkList<T> linkList2)
        {
            var ret = new LinkList<T>();
            ret.head = linkList1.head;
            if (linkList1 == null)
            {
                return linkList2;
            }
            if (linkList1 == null)
            {
                return linkList2;
            }

            Node<T> A = ret.head.Next;
            Node<T> B = linkList2.head.Next;
            while (A.Next != null)
            {
                A = A.Next;
            }
            A.Next = B;
            return ret;
        }
        ///<summary>
        /// 两个链表不重复的合并
        /// </summary>
        /// <param name = "linkList1" > 第一个链表 </ param >
        /// < param name="linkList2">第二个链表</param>
        public LinkList<T> Merge2(LinkList<T> linkList1, LinkList<T> linkList2)
        {
            Node<T> p = linkList1.Head.Next;
            Node<T> q = linkList2.Head.Next;
            LinkList<T> newlink = new LinkList<T>();
            newlink.head = linkList1.head;
            Node<T> Newtail = newlink.head;
            Newtail.Next = null;
            Node<T> newnode = new Node<T>();
            while (p != null && q != null)
            {
                while (p.Next != null && Convert.ToInt16(p.Data) == Convert.ToInt16(p.Next.Data))
                {
                    p = p.Next;
                }
                while (q.Next != null && Convert.ToInt16(q.Data) == Convert.ToInt16(q.Next.Data))
                {
                    q = q.Next;
                }
                if (Convert.ToInt16(p.Data) <= Convert.ToInt16(q.Data))
                {
                    newnode = p;
                    if (Convert.ToInt16(p.Data) == Convert.ToInt16(q.Data))
                    {
                        q = q.Next;
                    }
                    p = p.Next;
                }
                else
                {
                    newnode = q;
                    q = q.Next;
                }
                newnode.Next = null;
                Newtail.Next = newnode;
                Newtail = Newtail.Next;
            }
            if (p == null)
            {
                p = q;
            }

            while (p != null)
            {
                while (Convert.ToInt16(Newtail.Data) == Convert.ToInt16(p.Data))
                {
                    p = p.Next;
                }
                Newtail.Next = p;
                Newtail = Newtail.Next;
                p = p.Next;
            }
            return newlink;

        }
        /// <summary>
        /// 非降序链表合并排序输出（递归算法：）
        /// </summary>
        /// <param name="l1">链表1的头节点</param>
        /// <param name="l2">链表2的头节点</param>
        /// <returns></returns>
        public Node<T> Merge(Node<T> list1, Node<T> list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }
            if (Convert.ToDecimal(list1.Data) <= Convert.ToDecimal(list2.Data))
            {
                list1.Next = Merge(list1.Next, list2);
                return list1;
            }
            else
            {
                list2.Next = Merge(list1, list2.Next);
                return list2;
            }

        }
    }
}



