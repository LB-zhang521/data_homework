using System;


namespace BGLB.Project_01
{
    public class Program
    {
        public static void Main(string[] args)
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
            #region 单链表
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
            #endregion
            # region 希翼作业题未注释
               string s = Console.ReadLine();
               string[] p = s.Split(' ');
               LinkList<Array> obj = new LinkList<Array>();
               for (int i = 0; i < p.Length; i++)
               {
                   string[] l = p[i].Split('，');
                   string temp = l[0];
                   l[0] = "num=" + temp;
                   temp = l[1];
                   l[1] = "score=" + temp;
                   obj.Append(l);
               }
               Display(obj);
               Console.Read();
           
        }
        #endregion

        public static void Display(LinkList<Array> linkList)
        {
            Node<Array> A = linkList.Head.Next;
            if (linkList.Head == null)
            {
                Console.WriteLine("链表为空");
            }
            while (A != null)
            {
                Console.Write("[" + A.Data.GetValue(0) + "," + A.Data.GetValue(1) + "]");
                A = A.Next;
                Console.WriteLine();
            }
        }

    }
}
