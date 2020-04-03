using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7project1
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n;
        int leng;
        Pen pen = new Pen(Color.Blue);

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = this.CreateGraphics();
            drawCayLeyTree(n, 200, 310, leng, -Math.PI / 2);           
        }                  
        void drawCayLeyTree(int n, double x0,
            double y0,double leng,double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayLeyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayLeyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,
            double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        private void depth_Scroll(object sender, EventArgs e)
        {
            textBox_depth.Text = $"递归深度为:{depth.Value.ToString()}";
            n = depth.Value ;
        }    
        private void length_Scroll(object sender, EventArgs e)
        {
            textBox_length.Text = $"主干长度为:{length.Value.ToString()}";
            leng = length.Value * 10;
        }
        private void RightPer1_Scroll(object sender, EventArgs e)
        {
            
            textBox_per1.Text = $"右分支比为:{(RightPer1.Value / 10.0).ToString()}";
            per1 = RightPer1.Value / 10;
        }
        private void LeftPer2_Scroll(object sender, EventArgs e)
        {
            textBox_per2.Text = $"左分支比为:{(LeftPer2.Value / 10.0).ToString()}";
            per2 = LeftPer2.Value / 10;
        }

        private void RightTh1_Scroll(object sender, EventArgs e)
        {
            textBox_th1.Text = $"右分支角度为:{RightTh1.Value.ToString()}";
            th1 = RightTh1.Value * Math.PI / 180; 
        }

        private void LeftTh2_Scroll(object sender, EventArgs e)
        {
            textBox_th2.Text = $"左分支角度为:{LeftTh2.Value.ToString()}";
            th2 = LeftTh2.Value * Math.PI / 180; 
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
        }

        private void comboBox_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.FromName((string)comboBox_color.SelectedItem);
            pen = new Pen(color);
        }
    }
}
