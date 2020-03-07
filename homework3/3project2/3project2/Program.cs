using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3project2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Random random = new Random();
            Console.WriteLine("请选择您要计算的形状，如下：");
            Console.WriteLine("1、圆形 2、长方形 3、正方形 4、三角形");
            Console.WriteLine("生成的十个形状的面积如下：");
            for (int i = 0; i < 10; i++)
            {  
                string name = Convert.ToString(random.Next(1, 5));
                Shape shape = Factory.CreateShape(name);
                sum = sum + shape.getArea();
                Console.WriteLine($"面积为：{shape.getArea()}\n");
            }
            Console.WriteLine($"总面积为：{sum}");
            Console.ReadKey();
        }
    }
    public abstract class Shape
    {
        public float PI = 3.14f;
        public abstract double getArea();
        public abstract void Loading();
    }

}
