using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5project1
{
    class Program
    {      
        static void Main(string[] args)
        {
            //添加订单项
            List<OrderItem> orderitem1 = new List<OrderItem>();
            List<OrderItem> orderitem2 = new List<OrderItem>();
            List<OrderItem> orderitem3 = new List<OrderItem>();
            orderitem1.Add(new OrderItem("鞋子", 25, 25.2));
            orderitem2.Add(new OrderItem("裤子", 10, 19.8));
            orderitem3.Add(new OrderItem("衣服", 7, 34.2));
            //订单加入订单项
            Order order1 = new Order("01", "小王", orderitem1);
            Order order2 = new Order("02", "小明", orderitem2);
            Order order3 = new Order("03", "小向", orderitem3);

            OrderService orderservice = new OrderService();
            orderservice.AddOrder(order1);
            //重复订单
            orderservice.AddOrder(order2);
            orderservice.AddOrder(order2);
            orderservice.AddOrder(order3);
            //当前订单   
            Console.WriteLine("添加操作后当前订单为:");
            orderservice.ShowOrders();
            orderservice.SortOrders();
            Console.WriteLine("对订单号进行排序操作后当前订单为:");
            //改变的订单          
            orderservice.ShowOrders();
            //查询操作
            Console.WriteLine("查询操作：");
            orderservice.SeekID("01");   
            orderservice.SeekName("小向");
            //当前订单      
            orderservice.DeleteOrder(order2);
            Console.WriteLine("删除操作后当前订单为:");
            orderservice.ShowOrders();
        }
    }
}




