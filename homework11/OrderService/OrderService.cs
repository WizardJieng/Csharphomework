using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;


namespace OrderApp {

    /**
     * The service class to manage orders
     * */

    public class OrderService
    {
        //the order list
        private List<Order> orders;
       
        public List<Order> orders1;
        public List<OrderItem> orderItems;      

        OrderServiceContext context;

        public OrderService()
        {
            orders = new List<Order>();
        }

        public List<Order> Orders
        {
            get => orders;
        }

        public Order GetOrder(int id)
        {
            using (context = new OrderServiceContext())
            {
                orders1 = context.Orders.ToList();
                orderItems = context.OrderItems.ToList();
                
                context.SaveChanges();
                return orders1.FirstOrDefault(o => o.OrderId == id);

            }

        }

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException($"添加错误: 订单{order.OrderId} 已经存在了!");
            orders.Add(order);
            using (context = new OrderServiceContext())
            {
                context.Orders.Add(order);               
               
            }

        }

        public void RemoveOrder(int orderId)
        {

            Order order = GetOrder(orderId);
            using (context = new OrderServiceContext())
            {
                orders1 = context.Orders.ToList();
                orderItems = context.OrderItems.ToList();            

                if (order != null)
                {
                    orders.Remove(order);

                    for (int i = 0; i < orderItems.Count(); i++)
                    {
                        if (orderItems[i].OrderId == orderId)
                        {
                            context.OrderItems.Remove(orderItems[i]);
                        }
                    }

                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }
    
    public List<Order> QueryOrdersByGoodsName(string goodsName)
    {
        using (context = new OrderServiceContext())
        {
           
                orders1 = context.Orders.ToList();
                orderItems = context.OrderItems.ToList();              

                return orders1.Where(
                order => order.Items.Exists(item => item.GoodsName == goodsName))
                .OrderBy(o => o.TotalPrice)
                .ToList(); ;                                        
            }
    }

    public List<Order> QueryOrdersByCustomerName(string customerName)
    {
            using (context = new OrderServiceContext())
            {
                orders1 = context.Orders.ToList();              
                orderItems = context.OrderItems.ToList();               

                return orders1
            .Where(order => order.CustomerName == customerName)
            .OrderBy(o => o.TotalPrice)
            .ToList();
            }
           
    }

    public void UpdateOrder(Order newOrder)
    {
            Order oldOrder = GetOrder(newOrder.OrderId);
            using (context = new OrderServiceContext())
            {
                orders1 = context.Orders.ToList();
                orderItems = context.OrderItems.ToList();              
                
                if (oldOrder == null)
                    throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");
                orders.Remove(oldOrder);
                orders.Add(newOrder);

                for (int i = 0; i < orderItems.Count(); i++)
                {
                    if (orderItems[i].OrderId == newOrder.OrderId)
                    {
                        context.OrderItems.Remove(orderItems[i]);
                    }
                }

                context.Orders.Remove(oldOrder);
                context.Orders.Add(newOrder);
                context.SaveChanges();
            }                
    }

    public void Sort()
    {
        orders.Sort();
    }

    public void Sort(Func<Order, Order, int> func)
    {
        Orders.Sort((o1, o2) => func(o1, o2));
    }

    public void Export(String fileName)
    {
        XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
        using (FileStream fs = new FileStream(fileName, FileMode.Create))
        {
            xs.Serialize(fs, Orders);
        }
    }

    public void Import(string path)
    {
        XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            List<Order> temp = (List<Order>)xs.Deserialize(fs);
            temp.ForEach(order => {
                if (!orders.Contains(order))
                {
                    orders.Add(order);
                }
            });
        }
    }

    public object QueryByTotalAmount(float amout)
    {
        return orders
           .Where(order => order.TotalPrice >= amout)
           .OrderByDescending(o => o.TotalPrice)
           .ToList();
    }

}
  
}
