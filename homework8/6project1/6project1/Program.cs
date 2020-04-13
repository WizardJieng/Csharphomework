using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6project1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
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
         
            OrderService orderservice = new OrderService(orders);
            orderservice.AddOrder(order1);
            //重复订单
            orderservice.AddOrder(order2);
            orderservice.AddOrder(order2);
            orderservice.AddOrder(order3);
            //当前订单   
            Console.WriteLine("\n添加操作后当前订单为:");
            orderservice.ShowOrders();
            Console.WriteLine("\n将所有的订单序列化为XML文件后为:");
            orderservice.Export("s.xml");
            Console.WriteLine("\n从XML文件中载入订单为:");
            orderservice.Import("s.xml");
            orderservice.SortOrders();
            Console.WriteLine("\n对订单号进行排序操作后当前订单为:");
            //改变的订单          
            orderservice.ShowOrders();
            //查询操作
            Console.WriteLine("\n查询操作：");
            orderservice.SeekID("01");
            orderservice.SeekName("小向");
            //当前订单      
            orderservice.DeleteOrder("02");
            Console.WriteLine("\n删除操作后当前订单为:");
            orderservice.ShowOrders();
            
        }
    }
}
