namespace pamoka12_14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            numericUpDown3 = new NumericUpDown();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(12, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(375, 426);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(144, 26);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(84, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Count:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(402, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 73);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(402, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 148);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Random Data";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(144, 101);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(84, 27);
            numericUpDown3.TabIndex = 7;
            numericUpDown3.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 6;
            label3.Text = "To:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(144, 62);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(84, 27);
            numericUpDown2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "From:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel1);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(402, 262);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chart Style";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(144, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 30);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Column", "Line", "Point" });
            comboBox1.Location = new Point(144, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(84, 28);
            comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 80);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 10;
            label5.Text = "Chart Color: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 9;
            label4.Text = "Chart Type: ";
            // 
            // button1
            // 
            button1.Location = new Point(400, 409);
            button1.Name = "button1";
            button1.Size = new Size(252, 29);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 542);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private GroupBox groupBox3;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Button button1;
        private ColorDialog colorDialog1;
    }
}