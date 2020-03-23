using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5project1
{
    class Order
    {
        //订单需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
        //订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
        //订单的ID
        public string id
        {
            set; get;
        }
        //订单的收件人
        public string name
        {
            set; get;
        }
        //订单的总金额

        public double money_total
        {
            set; get;
        }
        //订单的地址
        public string address
        {
            set; get;
        }
        
        //订单项的集合
        List<OrderItem> orderitems;
        public Order(string id,  string name, List<OrderItem> orderitems)
        {
            this.id = id;
                    
            this.name = name;
            this.orderitems = orderitems;
            var seek = orderitems.Where(x => true);
            money_total = seek.Sum(i => i.UnitPrice);
        }
        public override string ToString()
        {
            StringBuilder itemTostring = new StringBuilder();
            foreach (OrderItem x in orderitems)
            {
                itemTostring.Append(x.ToString());
            }
            return $"id:{id}  name:{name}  {itemTostring}  money_total:{money_total}";            
        }
        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.id == id && m.name == name && m.address == address;
        }
    }
}
