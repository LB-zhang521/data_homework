using System;

namespace ConsoleApplication1
{

    public class LinkList<T>
    {
        private Node<T> head;
        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public LinkList(T[] arr, int j = 0)
        {
            head = new Node<T>();
            head = new Node<T>();
            for (int i = j; i < arr.Length; i++)
            {
                this.Attpend(arr[i]);
            }
        }
        public LinkList()
        {
            head = new Node<T>();
        }

        public void InsertPost(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or position is error!");
                return;
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next.Next;
                head.Next = q;
                return;
            }
            Node<T> p = head;
            int j = 0;
            while (p.Next != null && j < i)
            {
                p = p.Next;
                ++j;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
            else
            {
                Console.WriteLine("Position is error");
            }
        }
        public bool IsEmpty()
        {
            return head.Next == null ? true : false;
        }

        public void Insert(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or position is error!");
                return;
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head = q;
                return;
            }
            Node<T> p = head;
            Node<T> r = new Node<T>();
            int j = 0;
            while (p.Next != null && j < i)
            {
                r = p;
                p = p.Next;
                ++j;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p;
                r.Next = q;
            }
            else
            {
                Console.WriteLine("position is error");
            }
        }
        public T Delete(int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or position is error!");
                return default(T);
            }
            Node<T> q = new Node<T>();
            if (i == 1)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }
            Node<T> p = head;
            int j = 0;
            while (p.Next != null && j < i)
            {
                ++j;
                q = p;
                p = p.Next;
            }
            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The ith node is not exist");
                return default(T);
            }
        }

        public int GetLength()
        {
            Node<T> p = head.Next;
            int length = 0;
            while (p != null)
            {
                length++;
                p = p.Next;
            }
            return length;
        }
        public void ReversLinkList()
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
        public void Attpend(T item)
        {
            Node<T> s = new Node<T>(item);
            if (IsEmpty())
            {
                head.Next = s;
            }
            else
            {
                Node<T> p = head.Next;

                while (p.Next != null)
                {
                    p = p.Next;
                }
                p.Next = s;
            }
        }


        public LinkList<T> Merge1(LinkList<T> linkList1, LinkList<T> linkList2)
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
                while (p.Next != null &&Convert.ToInt16(p.Data) == Convert.ToInt16(p.Next.Data))
                {
                    p = p.Next;
                }
                while (q.Next!=null &&Convert.ToInt16(q.Data) == Convert.ToInt16(q.Next.Data))
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
        /// 递归 算法  不知道为什么有问题 力扣(LeetCode)上面搜的
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public Node<T> Merge(Node<T> l1, Node<T> l2)
        {
            if (l1 == null || l2 == null)
            {
                return l1 ?? l2;
            }
            if (Convert.ToInt32(l1.Data) < Convert.ToInt32(l2.Data))
            {
                l1.Next = Merge(l1.Next, l2);
                return l1;
            }
            else
            {
                l2.Next = Merge(l1, l2.Next);
                return l2;
            }

            }

            public void output()
        {
            Node<T> p = head.Next;
            while (p != null)
            {
                Console.Write(p.Data + "\n");
                p = p.Next;
            }
        }
        //public void input()
        //{
        //    // Console.WriteLine("输入若干个字符串(空格做间隔)：");
        //    string str = Console.ReadLine();
        //    string[] str1 = str.Split(' ');

        //    for (int i = 0; i < str1.Length; i++)
        //    {
        //        try
        //        {
        //            string[] stu = str1[i].Split(',');
        //            string temp = "[num=" + stu[0] + ",score=" + stu[1] + "]";
        //            this.Attpend(temp);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("出错：" + e.Message);
        //            break;
        //        }
        //    }

        //}


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
                Console.Write(A.Data + " ");
                A = A.Next;
            }
            Console.WriteLine();
        }

    }


}
