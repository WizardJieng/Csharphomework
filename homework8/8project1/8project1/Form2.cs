using _6project1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8project1
{
    public partial class Form2 : Form
    {      
        public Order orderN { get; set; }
        public string idN { get; set; }       
        public Form2()
        {
            InitializeComponent();                    
        }        
        public class Product
        {
            public static Dictionary<string, string> NameNoDic
            {
                get
                {
                    Dictionary<string, string> nameID = new Dictionary<string, string>
                {
                    { "鞋子", "001" },
                    { "裤子", "002" },
                    { "衣服", "003" },
                    { "手表", "004" },
                    { "帽子", "005" },                    
                };
                    return nameID;
                }
            }
            public static Dictionary<string, double> namePrice
            {
                get
                {
                    Dictionary<string, double> namePrice = new Dictionary<string, double>
                {
                    { "鞋子", 22.3},
                    { "裤子", 22.6},
                    { "衣服", 65.4},
                    { "手表", 115.6},
                    { "帽子", 62.2 },                    
                };
                    return namePrice;
                }
            }
        }            
        public class OrderID
        {
            private static readonly object Locker = new object();
            private static int sn = 3;

            public static string OrderId()
            {   //lock 关键字可确保当一个线程位于代码的临界区时，另一个线程不会进入该临界区。
                lock (Locker)   
                {
                    sn++;
                    return sn.ToString().PadLeft(2, '0');
                }
            }
        }       
        private void AddButton_Click(object sender, EventArgs e)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    string itemid = 
                        checkedListBox.GetItemText(checkedListBox.Items[i]);                   
                    int count = 0;
                    double UnitPrice = Product.namePrice[itemid];
                    switch (itemid)
                    {
                        case "鞋子": count = int.Parse(textBox1.Text); break;
                        case "裤子": count = int.Parse(textBox2.Text); break;
                        case "衣服": count = int.Parse(textBox3.Text); break;
                        case "手表": count = int.Parse(textBox4.Text); break;
                        case "帽子": count = int.Parse(textBox5.Text); break;
                    }
                    OrderItem orderItem = new OrderItem(itemid, count, UnitPrice);
                    orderItems.Add(orderItem);
                }
            }
            orderN = new Order(OrderID.OrderId(), textBox_name.Text, orderItems);
            Form1.orderservice.AddOrder(orderN);
            MessageBox.Show($"添加{textBox_name.Text}的订单成功！");          
        }       
    }
}


