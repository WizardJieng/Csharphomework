using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3project1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入你选择你要计算的图形：");
                Console.WriteLine("1.长方形");
                Console.WriteLine("2.正方形");
                Console.WriteLine("3.三角形");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("请输入长方形的长和宽:");
                        double length, width;
                        length = double.Parse(Console.ReadLine());
                        width = double.Parse(Console.ReadLine());
                        Shape shape;
                        shape = new Rectangle(length, width);
                        shape.getArea();
                        break;
                    case 2:
                        Console.WriteLine("请输入正方形的边长:");
                        double edge;
                        edge = double.Parse(Console.ReadLine());
                        shape = new Square(edge);
                        shape.getArea();
                        break;
                    case 3:
                        Console.WriteLine("请输入正方形的边长:");
                        double x;
                        double y;
                        double z;
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        z = double.Parse(Console.ReadLine());
                        shape = new Triangle(x, y, z);
                        shape.getArea();
                        break;
                    default:
                        Console.WriteLine("您输入有误，请重新输入!");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("输入错误");
            }
        }
    }
    
    abstract class Shape
    {
        public abstract void getArea();            
    }
    class Rectangle : Shape
    {
        double Area;
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override void getArea()
        {
            Area = length * width;
            Console.WriteLine("长={0},宽={1}", length, width);
            Console.WriteLine($"该长方形的面积为{Area}");
        }       
    }
    class Square : Rectangle
    {
        double Area;
        private double edge;
        public Square(double edge):base(edge,edge)
        {
            this.edge = edge;
        }
        public override void getArea()
        {
            Area = edge * edge;
            Console.WriteLine($"边长={edge}");
            Console.WriteLine($"该正方形的面积为{Area}");
        }       
    }
    class Triangle : Shape
    {
        double Area;
        private double x;
        private double y;
        private double z;
        private double a;
        public Triangle(double x, double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override void getArea()
        {
            a = (x + y + z) / 2;
            Area = Convert.ToInt32(Math.Sqrt(a * (a - x) * (a - y) * (a - z)));
            Console.WriteLine("边一 = {0},边二 = {1},边三 = {2}", x, y, z);
            Console.WriteLine($"该三角形的面积为{Area}");
        }       
    }   
}
