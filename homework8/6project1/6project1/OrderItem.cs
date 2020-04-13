using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6project1
{
    [Serializable]
    //订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
    //订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
    public class OrderItem
    {
        //订单项ID(商品名称)
        public string itemid
        {
            set; get;
        }
        //数量
        public int count
        {
            set; get;
        }
        //单价
        public double UnitPrice
        {
            set; get;
        }
        public OrderItem() { }
        public OrderItem(string itemid, int count, double UnitPrice)
        {
            this.itemid = itemid;
            this.count = count;
            this.UnitPrice = UnitPrice;
        }
        public override string ToString()
        {
            return $"itemid:{itemid}  count:{count}  UnitPrice:{UnitPrice}";
        }
        public override bool Equals(object obj)
        {
            OrderItem n = obj as OrderItem;
            return n != null && n.itemid == itemid && n.UnitPrice == UnitPrice && n.count == count;
        }
    }
}
