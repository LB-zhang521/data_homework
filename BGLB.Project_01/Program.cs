using System;

namespace BGLB.Project_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("顺序表测试");
            //testShunxu();
            //Console.WriteLine("链表测试");
            //testDanlianbiao();
            //Console.WriteLine("作业1测试");
            //zuoye1();
            Console.WriteLine("作业2测试");
            zuoye2();
            //  Console.WriteLine("作业3测试");
            //   zuoye3();
            Console.WriteLine("测试结束");
            Console.Read();

        }


        /// <summary>
        /// 顺序表的测试
        /// </summary>
        public static void testShunxu()
        {
            #region 顺序表
            /** SeqList<string> s = new SeqList<string>(5);
            Console.WriteLine(s.Last);
            Console.WriteLine(s.Maxsize);
            Console.WriteLine(s.Isfull());
            Console.WriteLine(s.IsEmpty());
            Console.WriteLine(s.GetLength());
            string a = "hello";
            string b = "world";
            s.Append(a);
            Console.WriteLine(s.Last);
            s.Append(a);
            s.Append(b);
            s.Append(b);
            s.Append(b);
            s.Insert(a, 2);
            s.output();
            s.Insert(s.Delete(1), 1);
            Console.WriteLine();
            s.output();
            Console.WriteLine();
            Console.WriteLine(s.Last);
            s.nizhi();
            Console.WriteLine(s.GetLength());
            s.output();
            Console.WriteLine();
            Console.ReadLine();
            SeqList<string> p = new SeqList<string>(5);
            p.input();
            p.output();
            Console.ReadLine();
            */
            #endregion
        }

        /// <summary>
        /// 单链表的测试
        /// </summary>
        public static void testDanlianbiao()
        {
            #region 单链表 测试
            /**
            LinkList<int> linkList = new LinkList<int>();
            Console.WriteLine("初始化单链表：");
            Console.WriteLine("链表刚生成后的长度：{0}", linkList.GetLength());

            linkList.Display(linkList);
            Console.WriteLine("初始化长度为10的单链表（采用Append的方式）：\n");
            for (int i = 1; i < 11; i++)
            {
                linkList.Append(i);
            }
            Console.WriteLine("初始化链表后的长度为：{0} \n", linkList.GetLength());
            linkList.Display(linkList);
            Console.WriteLine("在第三个元素之后插入888\n");
            linkList.InsertPost(888, 3);
            linkList.Display(linkList);
            Console.WriteLine("删除元素第四个元素{0}", linkList.Delete(4));
            linkList.Display(linkList);
            Console.WriteLine("在第三个位置插入888\n");
            linkList.Insert(888, 3);
            linkList.Display(linkList);
            Console.WriteLine("删除元素第三个元素{0}", linkList.Delete(3));
            linkList.Display(linkList);
            Console.WriteLine("逆序链表\n");
            linkList.ReversLinkList();
            linkList.Display(linkList);
            Console.WriteLine("清空单链表\n");
            linkList.Clear();
            Console.WriteLine("链表是否为空：{0}", linkList.IsEmpty());
            Console.WriteLine("链表清空后的长度：{0}", linkList.GetLength());
            linkList.Display(linkList);
            Console.Read();
      */
            #endregion
        }

        /// <summary>
        /// 希翼作业题1
        /// </summary>
        /// <param name="linkList"></param>
        public static void zuoye1()
        {
            string s = Console.ReadLine();
            string[] p = s.Split(' ');
            LinkList<Array> obj = new LinkList<Array>();
            for (int i = 0; i < p.Length; i++)
            {
                string[] l = p[i].Split(',');
                string temp = l[0];
                l[0] = "num=" + temp;
                temp = l[1];
                l[1] = "score=" + temp;
                obj.Append(l);
            }

            #region  希翼作业题1的输出

            Node<Array> A = obj.Head.Next;
            if (obj.Head == null)
            {
                Console.WriteLine("链表为空");
            }
            while (A != null)
            {
                Console.Write("[" + A.Data.GetValue(0) + "," + A.Data.GetValue(1) + "]");
                A = A.Next;
                Console.WriteLine();
            }

            #endregion
        }

        /// <summary>
        /// 希翼作业2
        /// </summary>
        public static void zuoye2()
        {
            LinkList<string> linkList1 = new LinkList<string>();
            linkList1.Input();
            LinkList<string> linkList2 = new LinkList<string>();
            linkList2.Input();
            Console.WriteLine("原始链表1：");
            linkList1.Display();
            Console.WriteLine("原始链表2：");
            linkList2.Display();

            //Console.WriteLine("两个链表首尾合并，会改变原始链表");
            //linkList1.Merge1(linkList2);
            //Console.WriteLine("合并后的链表：");
            //linkList1.Display();
            //Console.WriteLine("原始链表1：");
            //linkList1.Display();
            //Console.WriteLine("原始链表2：");
            //linkList2.Display();



            Console.WriteLine("两个链表首尾合并，不改变原始链表");
            LinkList<string> test1 = Merge123(linkList1, linkList2);
            Console.WriteLine("合并后的新链表：");
            test1.Display();
            Console.WriteLine("原始链表1：");
            linkList1.Display();
            Console.WriteLine("原始链表2：");
            linkList2.Display();

            #region 符合平台要求的
            //Console.WriteLine("两个非降序链表合并去重");
            //linkList1.Merge2(linkList2);
            //Console.WriteLine("合并去重后的链表");
            //linkList1.Display();
            //Console.WriteLine("原始链表1：");
            //linkList1.Display();
            //Console.WriteLine("原始链表2：");
            //linkList2.Display();
            #endregion

            //LinkList<string> h = new LinkList<string>();
            //Node<string> a = linkList1.Merge(linkList1.Head, linkList2.Head);
            //h.Head= a.Next;
            //Console.WriteLine("非降序链表合并排序输出（递归算法：）");
            //h.Display();
            //Console.WriteLine("原始链表1：");
            //linkList1.Display();
            //Console.WriteLine("原始链表2：");
            //linkList2.Display();
        }

        /// <summary>
        /// 希翼作业3
        /// </summary>
        public static void zuoye3()
        {
            #region 希翼作业3 已提交完成
            /**
            string s = Console.ReadLine();
            string[] p = s.Split(' ');
            int k = Convert.ToInt32(p[0]);
            LinkList<string> linkList = new LinkList<string>(p,1);
            // linkList.Display();
            
            if (k>linkList.GetLength())
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                  Node<string> q = linkList.Head.Next;
                            for (int i = k; i < linkList.GetLength(); i++)
                            {
                                q = q.Next;
                            }
                Console.WriteLine(q.Data);
            }
            Console.ReadLine();
    */
            #endregion
        }

        /// <summary>
        /// 不更改链表 两个链表首尾合并返回新链表
        /// </summary>
        /// <param name="La"></param>
        /// <param name="Lb"></param>
        /// <returns></returns>
        public static LinkList<string> Merge123(LinkList<string> La, LinkList<string> Lb)
        {
            LinkList<string> ret = new LinkList<string>();
            Node<string> p = La.Head.Next;
            while (p != null)
            {
                // Node<object> x = new Node<object>(p. Data) ;
                ret.Append(p.Data);
                p = p.Next;
            }

            p = ret.Head;
            while (p.Next != null)
            {
                p = p.Next;
            }
            p.Next = Lb.Head.Next;
            return ret;
        }
    }
}
