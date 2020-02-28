using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数据:");
            int Word = int.Parse(Console.ReadLine());         
            if (Word == 1)
            {
                Console.WriteLine("1没有素数因子");
            }
            Factor(Word);    
        }
        public static void Factor(int nums)
        {
            int i = 2;
            while (nums > 1)
            {
                if (Prime(i) && nums % i == 0)
                {
                    Console.WriteLine($"{i}");
                    nums = nums / i;
                    i = 2;
                    continue;
                }
                i++;
            }
        }
        public static bool Prime(int n)
        {
            if (n == 2)
                return true;
            for (int i = 2; i*i < n;i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
