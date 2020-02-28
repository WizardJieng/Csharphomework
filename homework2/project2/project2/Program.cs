using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                int num = 10;  //数组长度
                int[] array = new int[num];
                int max, min, sum, i;
                float avg;
                Random example = new Random();
                Console.WriteLine("该数组为：");
                for (i = 0; i < num; i++)
                {
                    array[i] = (int)(example.Next(1,55) * (num-1))+1;  //防止数过大，控制范围
                    Console.WriteLine($"{array[i]}");
                }               
                max = min = array[0];
                sum = 0;
                for (i = 0; i < num; i++)
                {
                    if (max < array[i])
                        max = array[i];
                    if (min > array[i])
                        min = array[i];
                    sum += array[i];
                }
                avg = (float)sum / num;
                Console.WriteLine($"最大值：{max}" + $"\n最小值：{min}" + $"\n所有数组元素的和：{sum}" + $"\n平均值：{avg}");
            }
            catch (Exception e)
            {
                Console.WriteLine("运算错误");
            }
            
        }
    }
 }

