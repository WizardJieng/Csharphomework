using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6project1.Tests
{
    
    [TestClass()]
    public class OrderServiceTests
    {
        List<Order> orders = new List<Order>();        
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderItem orderitem1 = new OrderItem("鞋子", 25, 25.2);
            OrderItem orderitem2 = new OrderItem("裤子", 10, 19.8);
            OrderItem orderitem3 = new OrderItem("衣服", 7, 34.2);
            OrderService orderservice = new OrderService(orders);
            Order order1 = new Order("01", "小王", new List<OrderItem> { orderitem1 });
            orderservice.AddOrder(order1);
            Assert.AreEqual(01,orderservice.orders.Count);
        }
        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderItem orderitem1 = new OrderItem("鞋子", 25, 25.2);
            OrderItem orderitem2 = new OrderItem("裤子", 10, 19.8);
            OrderItem orderitem3 = new OrderItem("衣服", 7, 34.2);
            OrderService orderservice = new OrderService(orders);
            Order order2 = new Order("02", "小明", new List<OrderItem> { orderitem2 });
            orderservice.DeleteOrder("02");
            Assert.AreEqual(order2, orderservice.orders.Count);
        }

        [TestMethod()]
        public void AlertOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ShowOrdersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SeekIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SeekNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortOrdersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }
    }
}