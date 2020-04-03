namespace _7project1
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
            this.Draw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftTh2 = new System.Windows.Forms.TrackBar();
            this.RightTh1 = new System.Windows.Forms.TrackBar();
            this.textBox_per2 = new System.Windows.Forms.TextBox();
            this.textBox_per1 = new System.Windows.Forms.TextBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_depth = new System.Windows.Forms.TextBox();
            this.LeftPer2 = new System.Windows.Forms.TrackBar();
            this.RightPer1 = new System.Windows.Forms.TrackBar();
            this.length = new System.Windows.Forms.TrackBar();
            this.depth = new System.Windows.Forms.TrackBar();
            this.textBox_th1 = new System.Windows.Forms.TextBox();
            this.textBox_th2 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(15, 3);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(85, 40);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_color);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.textBox_th2);
            this.panel1.Controls.Add(this.textBox_th1);
            this.panel1.Controls.Add(this.LeftTh2);
            this.panel1.Controls.Add(this.RightTh1);
            this.panel1.Controls.Add(this.textBox_per2);
            this.panel1.Controls.Add(this.textBox_per1);
            this.panel1.Controls.Add(this.textBox_length);
            this.panel1.Controls.Add(this.textBox_depth);
            this.panel1.Controls.Add(this.LeftPer2);
            this.panel1.Controls.Add(this.RightPer1);
            this.panel1.Controls.Add(this.length);
            this.panel1.Controls.Add(this.depth);
            this.panel1.Controls.Add(this.Draw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(649, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 653);
            this.panel1.TabIndex = 1;
            // 
            // LeftTh2
            // 
            this.LeftTh2.Location = new System.Drawing.Point(3, 359);
            this.LeftTh2.Maximum = 90;
            this.LeftTh2.Name = "LeftTh2";
            this.LeftTh2.Size = new System.Drawing.Size(194, 56);
            this.LeftTh2.TabIndex = 6;
            this.LeftTh2.Scroll += new System.EventHandler(this.LeftTh2_Scroll);
            // 
            // RightTh1
            // 
            this.RightTh1.Location = new System.Drawing.Point(3, 297);
            this.RightTh1.Maximum = 90;
            this.RightTh1.Name = "RightTh1";
            this.RightTh1.Size = new System.Drawing.Size(194, 56);
            this.RightTh1.TabIndex = 5;
            this.RightTh1.Scroll += new System.EventHandler(this.RightTh1_Scroll);
            // 
            // textBox_per2
            // 
            this.textBox_per2.Location = new System.Drawing.Point(203, 235);
            this.textBox_per2.Name = "textBox_per2";
            this.textBox_per2.Size = new System.Drawing.Size(127, 25);
            this.textBox_per2.TabIndex = 8;
            // 
            // textBox_per1
            // 
            this.textBox_per1.Location = new System.Drawing.Point(203, 173);
            this.textBox_per1.Name = "textBox_per1";
            this.textBox_per1.Size = new System.Drawing.Size(127, 25);
            this.textBox_per1.TabIndex = 7;
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(203, 111);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(127, 25);
            this.textBox_length.TabIndex = 6;
            // 
            // textBox_depth
            // 
            this.textBox_depth.Location = new System.Drawing.Point(203, 49);
            this.textBox_depth.Name = "textBox_depth";
            this.textBox_depth.Size = new System.Drawing.Size(127, 25);
            this.textBox_depth.TabIndex = 5;
            // 
            // LeftPer2
            // 
            this.LeftPer2.Location = new System.Drawing.Point(3, 226);
            this.LeftPer2.Name = "LeftPer2";
            this.LeftPer2.Size = new System.Drawing.Size(194, 56);
            this.LeftPer2.TabIndex = 4;
            this.LeftPer2.Scroll += new System.EventHandler(this.LeftPer2_Scroll);
            // 
            // RightPer1
            // 
            this.RightPer1.Location = new System.Drawing.Point(3, 173);
            this.RightPer1.Name = "RightPer1";
            this.RightPer1.Size = new System.Drawing.Size(194, 56);
            this.RightPer1.TabIndex = 3;
            this.RightPer1.Scroll += new System.EventHandler(this.RightPer1_Scroll);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(3, 111);
            this.length.Minimum = 1;
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(194, 56);
            this.length.TabIndex = 2;
            this.length.Value = 1;
            this.length.Scroll += new System.EventHandler(this.length_Scroll);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(3, 49);
            this.depth.Minimum = 1;
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(194, 56);
            this.depth.TabIndex = 1;
            this.depth.Tag = "";
            this.depth.Value = 1;
            this.depth.Scroll += new System.EventHandler(this.depth_Scroll);
            // 
            // textBox_th1
            // 
            this.textBox_th1.Location = new System.Drawing.Point(203, 297);
            this.textBox_th1.Name = "textBox_th1";
            this.textBox_th1.Size = new System.Drawing.Size(127, 25);
            this.textBox_th1.TabIndex = 11;
            // 
            // textBox_th2
            // 
            this.textBox_th2.Location = new System.Drawing.Point(203, 359);
            this.textBox_th2.Name = "textBox_th2";
            this.textBox_th2.Size = new System.Drawing.Size(127, 25);
            this.textBox_th2.TabIndex = 12;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(112, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(85, 40);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // comboBox_color
            // 
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Green",
            "Orange",
            "Purple"});
            this.comboBox_color.Location = new System.Drawing.Point(30, 421);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(150, 23);
            this.comboBox_color.TabIndex = 14;
            this.comboBox_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_color_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar depth;
        private System.Windows.Forms.TrackBar LeftPer2;
        private System.Windows.Forms.TrackBar RightPer1;
        private System.Windows.Forms.TrackBar length;
        private System.Windows.Forms.TextBox textBox_depth;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_per2;
        private System.Windows.Forms.TextBox textBox_per1;
        private System.Windows.Forms.TrackBar RightTh1;
        private System.Windows.Forms.TrackBar LeftTh2;
        private System.Windows.Forms.TextBox textBox_th2;
        private System.Windows.Forms.TextBox textBox_th1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox comboBox_color;
    }
}

