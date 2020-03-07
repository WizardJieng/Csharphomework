using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3project2
{
    class Triangle : Shape
    {       
        private double bottom;
        private double height;              
        public Triangle()
        {
            Loading();
        }
        public override double getArea()
        {     
            return bottom * height / 2; ;          
        }
        public override void Loading()
        {
            while (true)
            {
                Random random = new Random();             
                string bottomStr = Convert.ToString(random.Next(1, 11));              
                string heightStr = Convert.ToString(random.Next(1, 11));                               
                Console.WriteLine($"三角形底为：{bottomStr}");
                Console.WriteLine($"三角形高为：{heightStr}");
                if(!double.TryParse(bottomStr, out bottom) || !double.TryParse(heightStr, out height))
                {
                    Console.Write("输入数据出现非法字符，");
                    continue;
                } 
                break;
            }
        }
    }
}
