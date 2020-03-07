using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3project2
{
    class Square : Rectangle
    {      
        private double edge;
        public Square() 
        {
            Loading();
        }
        public override double getArea()
        {
            return edge * edge;           
        }
        public override void Loading()
        {
            while (true)
            {
                Random random = new Random();             
                string edgeStr = Convert.ToString(random.Next(1, 11));
                Console.WriteLine($"正方形的边长为：{edgeStr}");
                if (!double.TryParse(edgeStr, out edge))
                {
                    Console.Write("输入数据出现非法字符，");
                    continue;
                }
                break;
            }
        }
    }
}
