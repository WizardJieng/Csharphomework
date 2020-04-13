using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _6project1;

namespace _8project1
{
    public partial class Form1 : Form
    {
        public static List<Order> orders = new List<Order>();
        public static OrderService orderservice = new OrderService(orders);
        public string KeyWord { set; get; }     
        public Form1()
        {           
            InitializeComponent();           
            //添加订单项
            List<OrderItem> orderitem1 = new List<OrderItem>();
            List<OrderItem> orderitem2 = new List<OrderItem>();
            List<OrderItem> orderitem3 = new List<OrderItem>();
            orderitem1.Add(new OrderItem("鞋子", 25, 25.2));
            orderitem1.Add(new OrderItem("裤子", 32, 23.2));
            orderitem1.Add(new OrderItem("衣服", 22, 52.5));

            orderitem2.Add(new OrderItem("鞋子", 33, 26.3));
            orderitem2.Add(new OrderItem("裤子", 36, 19.8));
            orderitem2.Add(new OrderItem("衣服", 27, 56.5));

            orderitem3.Add(new OrderItem("鞋子", 29, 24.4));
            orderitem3.Add(new OrderItem("裤子", 34, 21.5));
            orderitem3.Add(new OrderItem("衣服", 26, 59.6));
            //订单加入订单项
            Order order1 = new Order("01", "小王", orderitem1);
            Order order2 = new Order("02", "小明", orderitem2);
            Order order3 = new Order("03", "小向", orderitem3);
           
            orderservice.AddOrder(order1);          
            orderservice.AddOrder(order2);
            orderservice.AddOrder(order3);
            OrderBindingSource.DataSource = orders;
            textBox_Search.DataBindings.Add("Text", this, "KeyWord");
        }       
        private void SeekID_btn_Click(object sender, EventArgs e)
        {
            if (KeyWord == null || KeyWord == "")
            {
                OrderBindingSource.DataSource = orders;                
            }
            else
            {
                OrderBindingSource.DataSource =
                orders.Where(s => s.id == KeyWord);
            }
        }
        private void SeekName_btn_Click(object sender, EventArgs e)
        {
            if (KeyWord == null || KeyWord == "")
            {
                OrderBindingSource.DataSource = orders;
            }
            else
            {
                OrderBindingSource.DataSource =
                orders.Where(s => s.name == KeyWord);
            }
        }      
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            new Form2().Show();                
        }       
        private void ImportButton_Click(object sender, EventArgs e)
        {           
            openFileDialog.Filter = "订单(*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                             
                label.Text = openFileDialog.FileName;
                orderservice.Import(openFileDialog.FileName);
                using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName))
                {
                    textBoxFile.Text = sr.ReadToEnd();
                }                                                                          
            }
        }
        private void ExportButton_Click_1(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "订单(*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                label.Text = saveFileDialog.FileName;               
                orderservice.Export(saveFileDialog.FileName);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow order in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(order);              
            }
            MessageBox.Show("删除成功！");
        }
    }   
}
