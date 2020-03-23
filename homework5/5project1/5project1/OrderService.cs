using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5project1
{  
    class OrderService
    {
        //OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
        //订单的集合
        List<Order> orders = new List<Order>();
        public void AddOrder(Order m)
        {
            foreach (Order x in orders)
            {
                if (m.Equals(x))
                {
                    Console.WriteLine("订单添加重复，添加失败");
                    return;
                }
            }
            orders.Add(m);
        }
        public void DeleteOrder(Order m)
        {
            foreach (Order x in orders)
            {
                if (m.Equals(x))
                {
                    orders.Remove(x);
                    Console.WriteLine($"删除订单{m.id}成功");
                    return;
                }                              
            }
        }
        public void AlertOrder()
        {
            //不知道还有啥可以修改的，而且难的也不会写，唉
        }
        //打印订单
        public void ShowOrders()
        {
            foreach (Order x in orders)
            {
                Console.WriteLine(x);
            }
        }
        public void SeekID(string id)
        {
            var ID = from m in orders
                          where m.id == id
                          orderby m.money_total descending
                          select m;
            StringBuilder res = new StringBuilder();

            foreach (Order m in ID)
            {
                res.Append(m.ToString());
            }
            Console.WriteLine(res);
        }
        public void SeekName(string name)
        {
            var Name = from m in orders
                          where m.name == name
                          orderby m.money_total descending
                          select m;

            StringBuilder res = new StringBuilder();

            foreach (Order m in Name)
            {
                res.Append(m.ToString());
            }
            Console.WriteLine(res);

        }     
        public void SortOrders()
        {
            var Sort = from m in orders
                          where true
                          orderby m.id descending
                          select m;
            orders = Sort.ToList();
        }      
    }
}

