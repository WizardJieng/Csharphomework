namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.计算 = new System.Windows.Forms.Button();
            this.comboBox_word = new System.Windows.Forms.ComboBox();
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 计算
            // 
            this.计算.Location = new System.Drawing.Point(350, 318);
            this.计算.Name = "计算";
            this.计算.Size = new System.Drawing.Size(100, 33);
            this.计算.TabIndex = 0;
            this.计算.Text = "计算";
            this.计算.UseVisualStyleBackColor = true;
            this.计算.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // comboBox_word
            // 
            this.comboBox_word.FormattingEnabled = true;
            this.comboBox_word.Location = new System.Drawing.Point(340, 152);
            this.comboBox_word.Name = "comboBox_word";
            this.comboBox_word.Size = new System.Drawing.Size(121, 23);
            this.comboBox_word.TabIndex = 1;
            // 
            // textBox_num1
            // 
            this.textBox_num1.Location = new System.Drawing.Point(157, 150);
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(100, 25);
            this.textBox_num1.TabIndex = 2;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(350, 255);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(100, 25);
            this.textBox_result.TabIndex = 3;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // textBox_num2
            // 
            this.textBox_num2.Location = new System.Drawing.Point(541, 150);
            this.textBox_num2.Name = "textBox_num2";
            this.textBox_num2.Size = new System.Drawing.Size(100, 25);
            this.textBox_num2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_num2);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_num1);
            this.Controls.Add(this.comboBox_word);
            this.Controls.Add(this.计算);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 计算;
        private System.Windows.Forms.ComboBox comboBox_word;
        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

