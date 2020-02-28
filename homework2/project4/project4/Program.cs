using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[101];
            for (int i = 2; i <= 100; i++)
            {
                a[i] = 1;
            }
            for (int i = 2; i <= 100; i++)
            {
                if (a[i] == 1)
                {
                    int j = i + 1;
                    while (j <= 100)
                    {
                        if (a[j] == 1 && j % i == 0)
                        {
                            a[j] = 0;
                        }
                        j++;
                    }
                }
            }
            Console.WriteLine("2~100之间的素数为：");
            for (int i = 2; i <= 100; i++)
                if (a[i] == 1)
                    Console.WriteLine($"{i}");
        }
    }
}
