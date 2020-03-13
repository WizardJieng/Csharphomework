using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4project1
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> next { get; set; }
        public T data { get; set; }

        public Node(T t)
        {
            next = null;
            data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for (Node<T> n = head; n != null; n = n.next) 
            {
                action(n.data);                
            }           
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            intlist.ForEach(x => Console.WriteLine(x));

            int sum = 0;
            intlist.ForEach(delegate (int x) { sum += x; });
            Console.WriteLine($"和为：{sum}");

            int max = 0;
            intlist.ForEach(delegate (int x) { if (max < x) max = x; });
            Console.WriteLine($"最大值为：{max}");

            int min = 0;
            intlist.ForEach(delegate (int x) { if (min > x) min = x; });
            Console.WriteLine($"最小值为：{min}");

        }
    }
}