using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3project2
{
    class Circle:Shape
    {
        double radius;
        public Circle() 
        {
            Loading();
        }
        public override double getArea()
        {
            return PI * radius * radius;
        }
        public override void Loading()
        {
            while (true)
            {
                Random random = new Random();             
                string radiusStr = Convert.ToString(random.Next(1, 11));
                Console.WriteLine($"圆形的半径为：{radiusStr}");
                if (!double.TryParse(radiusStr, out radius))
                {
                    Console.Write("输入数据出现非法字符，");
                    continue;
                }
                break;
            }
        }       
    }
}
