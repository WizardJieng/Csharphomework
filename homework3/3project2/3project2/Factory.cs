using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3project2
{
    class Factory
    {
        public static Shape CreateShape(string name)
        {
            Shape mshape = null;
            switch (name)
            {
                case "1":
                    mshape = new Circle();
                    break;
                case "2":
                    mshape = new Rectangle();
                    break;
                case "3":
                    mshape = new Square();
                    break;
                case "4":
                    mshape = new Triangle();
                    break;
                default:
                    Console.WriteLine("系统找不到您选择的形状！");
                    Console.ReadKey();
                    return null;
            }
            return mshape;
        }
    }
}
