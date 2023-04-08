namespace FractionCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.RadioButton();
            this.Minus = new System.Windows.Forms.RadioButton();
            this.Multipication = new System.Windows.Forms.RadioButton();
            this.Divide = new System.Windows.Forms.RadioButton();
            this.first2 = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.second2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(110, 152);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(29, 22);
            this.first.TabIndex = 0;
            this.first.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.Location = new System.Drawing.Point(3, 55);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(35, 20);
            this.Addition.TabIndex = 9;
            this.Addition.TabStop = true;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Minus
            // 
            this.Minus.AutoSize = true;
            this.Minus.Location = new System.Drawing.Point(3, 81);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(32, 20);
            this.Minus.TabIndex = 10;
            this.Minus.TabStop = true;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.CheckedChanged += new System.EventHandler(this.Minus_CheckedChanged);
            // 
            // Multipication
            // 
            this.Multipication.AutoSize = true;
            this.Multipication.Location = new System.Drawing.Point(3, 29);
            this.Multipication.Name = "Multipication";
            this.Multipication.Size = new System.Drawing.Size(33, 20);
            this.Multipication.TabIndex = 8;
            this.Multipication.TabStop = true;
            this.Multipication.Text = "*";
            this.Multipication.UseVisualStyleBackColor = true;
            this.Multipication.CheckedChanged += new System.EventHandler(this.Multipication_CheckedChanged);
            // 
            // Divide
            // 
            this.Divide.AutoSize = true;
            this.Divide.Location = new System.Drawing.Point(3, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(32, 20);
            this.Divide.TabIndex = 7;
            this.Divide.TabStop = true;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.CheckedChanged += new System.EventHandler(this.Divide_CheckedChanged);
            // 
            // first2
            // 
            this.first2.Location = new System.Drawing.Point(110, 199);
            this.first2.Name = "first2";
            this.first2.Size = new System.Drawing.Size(29, 22);
            this.first2.TabIndex = 2;
            this.first2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(297, 154);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(29, 22);
            this.second.TabIndex = 3;
            this.second.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // second2
            // 
            this.second2.Location = new System.Drawing.Point(297, 200);
            this.second2.Name = "second2";
            this.second2.Size = new System.Drawing.Size(29, 22);
            this.second2.TabIndex = 4;
            this.second2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(451, 154);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(29, 22);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(451, 199);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(29, 22);
            this.txtResult2.TabIndex = 6;
            this.txtResult2.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "=";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Divide);
            this.flowLayoutPanel1.Controls.Add(this.Multipication);
            this.flowLayoutPanel1.Controls.Add(this.Addition);
            this.flowLayoutPanel1.Controls.Add(this.Minus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(186, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(53, 108);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 61);
            this.button1.TabIndex = 11;
            this.button1.Text = "Perform Operation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.second2);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first2);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.RadioButton Addition;
        private System.Windows.Forms.RadioButton Minus;
        private System.Windows.Forms.RadioButton Multipication;
        private System.Windows.Forms.RadioButton Divide;
        private System.Windows.Forms.TextBox first2;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox second2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

