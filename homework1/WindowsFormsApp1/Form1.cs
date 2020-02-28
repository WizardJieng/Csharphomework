using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "数字一";
            label2.Text = "运算符号";
            label3.Text = "数字二";
            label4.Text = "结果";
            comboBox_word.Items.Add("+");
            comboBox_word.Items.Add("-");
            comboBox_word.Items.Add("*");
            comboBox_word.Items.Add("/");
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            try
            {
                int WordOne = int.Parse(textBox_num1.Text);
                int WordTwo = int.Parse(textBox_num2.Text);
                string Result = "";
                switch (comboBox_word.Text)
                {
                    case "+":
                        Result = Convert.ToString(WordOne + WordTwo);
                        break;
                    case "-":
                        Result = Convert.ToString(WordOne - WordTwo);
                        break;
                    case "*":
                        Result = Convert.ToString(WordOne * WordTwo);
                        break;
                    case "/":
                        Result = Convert.ToString(WordOne / WordTwo);
                        break;
                    default:
                        break;
                }
                textBox_result.Text = Result;
            }
            catch (FormatException)
            {
                textBox_result.Text = " 错误的格式";
            }
            catch (OverflowException)
            {
                textBox_result.Text = " 溢出错误";
            }
            catch (Exception)
            {
                textBox_result.Text = " 运算错误";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
