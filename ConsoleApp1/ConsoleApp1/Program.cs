using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" 请输入数字一：");
                int WordOne = int.Parse(Console.ReadLine());
                Console.WriteLine(" 请输入运算符号：+ - * /");
                string Fuhao = Console.ReadLine();
                Console.WriteLine(" 请输入数字二：");
                int WordTwo = int.Parse(Console.ReadLine());
                string Result = "";
                switch (Fuhao)
                {
                    case "+":
                        Result = Convert.ToString(WordOne + WordTwo);
                        break;
                    case "-":
                        Result = Convert.ToString(WordOne - WordTwo);
                        break;
                    case "*":
                        Result = Convert.ToString(WordOne * WordTwo);
                        break;
                    case "/":
                        Result = Convert.ToString(WordOne / WordTwo);
                        break;
                }
                Console.WriteLine($" 结果是：{Result}");
            }
            catch (Exception)
            {
                Console.WriteLine("除法运算数字二不能为零");
            }
            return;
        }
    }
}
