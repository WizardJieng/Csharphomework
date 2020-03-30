using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _6project1
{  
    public class OrderService
    {
        //OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
        //订单的集合
        public List<Order> orders = new List<Order>();
        public void AddOrder(Order m)
        {
            foreach (Order x in orders)
            {
                if (m.Equals(x))
                {
                    Console.WriteLine("\n订单添加重复，添加失败!!!");
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
                    Console.WriteLine($"\n删除订单{m.id}成功!!!");
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
            foreach (Order m in ID)
            {
                Console.WriteLine(m);
            }
        }
        public void SeekName(string name)
        {
            var Name = from m in orders
                       where m.name == name
                       orderby m.money_total descending
                       select m;
            foreach (Order m in Name)
            {
                Console.WriteLine(m);
            }
        }
        public void SortOrders()
        {
            var Sort = from m in orders
                       where true
                       orderby m.id descending
                       select m;
            orders = Sort.ToList();
        }
        //在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件
        public void Export()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xml.Serialize(fs, orders);
            }        
            Console.WriteLine(File.ReadAllText("s.xml"));
        }
        //添加一个Import方法可以从XML文件中载入订单
        public void Import()
        {          
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                List<Order>orderlist= (List<Order>)xml.Deserialize(fs);
                foreach (Order o in orderlist)
                {
                    Console.WriteLine(o);
                }             
            }           
        }
    }
}
