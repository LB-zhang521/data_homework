using System;

namespace BGLB.Project_01
{
    public class SeqList<T>
    {
        private int maxsize;
        private T[] data;
        private int last;
        public T this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public int Last
        {
            get
            {
                return last;
            }
        }
        public int Maxsize
        {
            get
            {
                return maxsize;
            }
            set
            {
                maxsize = value;
            }
        }
        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="size"></param>
        public SeqList(int size)
        {
            data = new T[size];
            maxsize = size;
            last = -1;
        }
        /// <summary>
        /// 判断顺序表是否为满
        /// </summary>
        /// <returns></returns>
        public bool Isfull()
        {
            bool ret = false;
            if (last + 1 >= maxsize)
            {
                ret = !ret;
            }
            return ret;
        }
        /// <summary>
        /// 判断顺序表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            bool ret = false;
            if (last + 1 <= 0)
            {
                ret = !ret;
            }
            return ret;

        }
        /// <summary>
        /// 在顺序表第i个位置插入一个新元素item
        /// </summary>
        /// <param name="item">新元素</param>
        /// <param name="i">插入的索引</param>
        public void Insert(T item, int i)
        {
            if (!this.Isfull())
            {
                last = last + 1;
                for (int j = last; j > i; j--)
                {
                    var temp = this[j - 1];
                    this[j] = temp;
                }
                this[i] = item;

            }
            else
            {
                Console.WriteLine("数据表已满,,无法进行插入操作");
            }
        }
        /// <summary>
        /// 删除顺序表第i个元素
        /// </summary>
        /// <param name="i"></param>
        /// <returns>删除的元素</returns>
        public T Delete(int i)
        {
            var ret = default(T);
            if (i == last)
            {
                ret = this[i];
            }
            if (i < last && i >= 0)
            {
                ret = this[i];
                for (int j = i; j < last; j++)
                {
                    this[j] = this[j + 1];
                }
            }
            last = last - 1;
            return ret;
        }
        /// <summary>
        /// 在表末尾追加新元素item
        /// </summary>
        /// <param name="item"></param>
        public void Append(T item)
        {
            if (!this.Isfull())
            {
                this[last + 1] = item;
                last = last + 1;
            }
            else
            {
                Console.WriteLine("数据表已满，无法进行追加操作");
            }
        }
        /// <summary>
        /// 顺序表的现有长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            int len = 0;
            for (int i = 0; i <= this.last; i++)
            {
                if (this[i] != null)
                {
                    ++len;
                }
            }
            return len;
        }
        /// <summary>
        /// 返回一个去重之后的新顺序表，并且不改变原顺序表；
        /// </summary>
        /// <param name="La">需要去重的数据表</param>
        /// <returns>去重之后的顺序表</returns>
        public SeqList<T> Purge(SeqList<T> La)
        {
            SeqList<T> Lb = new SeqList<T>(La.Maxsize);
            Lb.Append(La[0]);
            for (int i = 1; i <= La.GetLength() - 1; i++)
            {
                int j;
                for (j = 0; j <= Lb.GetLength() - 1; j++)
                {
                    if (La[i].Equals(Lb[j]))
                    {
                        break;
                    }
                }
                if (j > Lb.GetLength() - 1)
                {
                    Lb.Append(La[i]);
                }
            }
            return Lb;
        }
        /// <summary>
        /// 顺序表的去重，相同項只留一个，注意：此方法会删除原表中的相同項，
        /// </summary>
        public void Purge2()
        {
            for (int i = 0; i < this.GetLength(); i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (this[i].Equals(this[j]))
                    {
                        this.Delete(i);
                        i--;
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// 循环 格式化输出 此顺序表 的每一项
        /// </summary>
        public void output()
        {
            for (int i = 0; i < this.GetLength(); i++)
            {
                Console.Write(this[i] + "\t");
            }
        }
        /// <summary>
        /// 倒序，让顺序表头尾交换
        /// </summary>
        public void nizhi()
        {
            for (int i = 0; i < this.GetLength(); i++)
            {
                this.Insert(this.Delete(i), 0);
            }
        }
        /// <summary>
        /// 将输入的字符串，用空格分割并写入到顺序表;
        /// </summary>
        public void input()
        {
            Console.WriteLine("输入若干个字符串，使用空格隔开：");
            string str = Console.ReadLine();
            string[] str1 = str.Split(' ');
            for (int i = 0; i < str1.Length; i++)
            {
                try
                {
                    object temp = str1[i];
                    this.Append((T)temp);
                }
                catch (Exception e)
                {
                    Console.WriteLine("出错：" + e.Message);
                    break;
                }
            }
        }
    }
}
