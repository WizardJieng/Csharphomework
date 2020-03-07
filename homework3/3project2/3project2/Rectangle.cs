using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3project2
{
    class Rectangle : Shape
    {       
        private double length;
        private double width;
        public Rectangle()
        {
            Loading();
        }
        public override double getArea()
        {
            return length * width;            
        }
        public override void Loading()
        {
            while (true)
            {
                Random random = new Random();               
                string lengthStr = Convert.ToString(random.Next(1, 11));                              
                string widthStr = Convert.ToString(random.Next(1, 11));
                Console.WriteLine($"长方形的长为：{lengthStr}");
                Console.WriteLine($"长方形的宽为：{widthStr}");
                if (!double.TryParse(lengthStr, out length) || !double.TryParse(widthStr, out width))
                {
                    Console.Write("输入数据出现非法字符，");
                    continue;
                }
                break;
            }
        }
    }
}
