namespace CreditCardInterestCalculator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Case1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Case2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Case3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Case1.SuspendLayout();
            this.Case2.SuspendLayout();
            this.Case3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Case1);
            this.tabControl1.Controls.Add(this.Case2);
            this.tabControl1.Controls.Add(this.Case3);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 166);
            this.tabControl1.TabIndex = 0;
            // 
            // Case1
            // 
            this.Case1.Controls.Add(this.label1);
            this.Case1.Controls.Add(this.button1);
            this.Case1.Location = new System.Drawing.Point(4, 25);
            this.Case1.Margin = new System.Windows.Forms.Padding(4);
            this.Case1.Name = "Case1";
            this.Case1.Padding = new System.Windows.Forms.Padding(4);
            this.Case1.Size = new System.Drawing.Size(1109, 137);
            this.Case1.TabIndex = 0;
            this.Case1.Text = "Case 1";
            this.Case1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1075, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 person has 1 wallet and 3 cards (1 Visa, 1 MC 1 Discover) – Each Card has a bal" +
    "ance of $100 – calculate the total interest (simple interest) for this person an" +
    "d per card. ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1073, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Process Case 1 Interest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Case2
            // 
            this.Case2.Controls.Add(this.label2);
            this.Case2.Controls.Add(this.button3);
            this.Case2.Location = new System.Drawing.Point(4, 25);
            this.Case2.Margin = new System.Windows.Forms.Padding(4);
            this.Case2.Name = "Case2";
            this.Case2.Padding = new System.Windows.Forms.Padding(4);
            this.Case2.Size = new System.Drawing.Size(1109, 137);
            this.Case2.TabIndex = 1;
            this.Case2.Text = "Case 2";
            this.Case2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1070, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "1 person has 2 wallets  Wallet 1 has a Visa and Discover , wallet 2 a MC -  each " +
    "card has $100 balance - calculate the total interest for this person and interes" +
    "t per wallet";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1073, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Process Case 2 Interest";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Case3
            // 
            this.Case3.Controls.Add(this.label4);
            this.Case3.Controls.Add(this.label3);
            this.Case3.Controls.Add(this.button2);
            this.Case3.Location = new System.Drawing.Point(4, 25);
            this.Case3.Margin = new System.Windows.Forms.Padding(4);
            this.Case3.Name = "Case3";
            this.Case3.Size = new System.Drawing.Size(1109, 137);
            this.Case3.TabIndex = 2;
            this.Case3.Text = "Case 3";
            this.Case3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "total interest(simple interest) for each person and interest per wallet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1043, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "2 people have 1 wallet each,  person 1 has 1 wallet , with 2 cards MC and visa pe" +
    "rson 2 has 1 wallet – 1 visa and 1 MC -  each card has $100 balance - calculate " +
    "the ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1073, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Process Case 3 Interest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 205);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1108, 220);
            this.textBox1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(977, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Clear Text Field";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 434);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Case1.ResumeLayout(false);
            this.Case1.PerformLayout();
            this.Case2.ResumeLayout(false);
            this.Case2.PerformLayout();
            this.Case3.ResumeLayout(false);
            this.Case3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Case1;
        private System.Windows.Forms.TabPage Case2;
        private System.Windows.Forms.TabPage Case3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

