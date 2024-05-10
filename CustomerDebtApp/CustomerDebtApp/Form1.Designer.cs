namespace CustomerDebtApp
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
            this.Dequeue = new System.Windows.Forms.Button();
            this.Enqueue = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.AmountOwed_Label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Display_Info = new System.Windows.Forms.TextBox();
            this.AmountOwed_TextBox = new System.Windows.Forms.TextBox();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.Age_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.CustomerCount = new System.Windows.Forms.Label();
            this.Total_Owed_Label = new System.Windows.Forms.Label();
            this.Customer_Max_Debt_Label = new System.Windows.Forms.Label();
            this.Peek = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dequeue
            // 
            this.Dequeue.Location = new System.Drawing.Point(144, 151);
            this.Dequeue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(63, 23);
            this.Dequeue.TabIndex = 24;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            this.Dequeue.Click += new System.EventHandler(this.Dequeue_Click);
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(53, 151);
            this.Enqueue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(67, 23);
            this.Enqueue.TabIndex = 23;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(63, 6);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(38, 13);
            this.Name_Label.TabIndex = 22;
            this.Name_Label.Text = "Name:";
            // 
            // AmountOwed_Label
            // 
            this.AmountOwed_Label.AutoSize = true;
            this.AmountOwed_Label.Location = new System.Drawing.Point(63, 123);
            this.AmountOwed_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountOwed_Label.Name = "AmountOwed_Label";
            this.AmountOwed_Label.Size = new System.Drawing.Size(77, 13);
            this.AmountOwed_Label.TabIndex = 21;
            this.AmountOwed_Label.Text = "Amount Owed:";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(63, 52);
            this.Address_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(48, 13);
            this.Address_Label.TabIndex = 20;
            this.Address_Label.Text = "Address:";
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Location = new System.Drawing.Point(63, 31);
            this.Age_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(29, 13);
            this.Age_Label.TabIndex = 19;
            this.Age_Label.Text = "Age:";
            // 
            // Display_Info
            // 
            this.Display_Info.Location = new System.Drawing.Point(53, 188);
            this.Display_Info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Display_Info.Multiline = true;
            this.Display_Info.Name = "Display_Info";
            this.Display_Info.Size = new System.Drawing.Size(295, 63);
            this.Display_Info.TabIndex = 17;
            // 
            // AmountOwed_TextBox
            // 
            this.AmountOwed_TextBox.Location = new System.Drawing.Point(144, 120);
            this.AmountOwed_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AmountOwed_TextBox.Name = "AmountOwed_TextBox";
            this.AmountOwed_TextBox.Size = new System.Drawing.Size(179, 20);
            this.AmountOwed_TextBox.TabIndex = 16;
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(144, 48);
            this.Address_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Address_TextBox.Multiline = true;
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(179, 67);
            this.Address_TextBox.TabIndex = 15;
            // 
            // Age_TextBox
            // 
            this.Age_TextBox.Location = new System.Drawing.Point(144, 27);
            this.Age_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Age_TextBox.Name = "Age_TextBox";
            this.Age_TextBox.Size = new System.Drawing.Size(179, 20);
            this.Age_TextBox.TabIndex = 14;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(144, 6);
            this.Name_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(179, 20);
            this.Name_TextBox.TabIndex = 13;
            // 
            // CustomerCount
            // 
            this.CustomerCount.AutoSize = true;
            this.CustomerCount.Location = new System.Drawing.Point(337, 27);
            this.CustomerCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerCount.Name = "CustomerCount";
            this.CustomerCount.Size = new System.Drawing.Size(0, 13);
            this.CustomerCount.TabIndex = 25;
            // 
            // Total_Owed_Label
            // 
            this.Total_Owed_Label.AutoSize = true;
            this.Total_Owed_Label.Location = new System.Drawing.Point(340, 70);
            this.Total_Owed_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Total_Owed_Label.Name = "Total_Owed_Label";
            this.Total_Owed_Label.Size = new System.Drawing.Size(0, 13);
            this.Total_Owed_Label.TabIndex = 26;
            // 
            // Customer_Max_Debt_Label
            // 
            this.Customer_Max_Debt_Label.AutoSize = true;
            this.Customer_Max_Debt_Label.Location = new System.Drawing.Point(340, 101);
            this.Customer_Max_Debt_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Customer_Max_Debt_Label.Name = "Customer_Max_Debt_Label";
            this.Customer_Max_Debt_Label.Size = new System.Drawing.Size(0, 13);
            this.Customer_Max_Debt_Label.TabIndex = 27;
            // 
            // Peek
            // 
            this.Peek.Location = new System.Drawing.Point(240, 151);
            this.Peek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Peek.Name = "Peek";
            this.Peek.Size = new System.Drawing.Size(50, 23);
            this.Peek.TabIndex = 28;
            this.Peek.Text = "Peek";
            this.Peek.UseVisualStyleBackColor = true;
            this.Peek.Click += new System.EventHandler(this.Peek_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 292);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Peek);
            this.Controls.Add(this.Customer_Max_Debt_Label);
            this.Controls.Add(this.Total_Owed_Label);
            this.Controls.Add(this.CustomerCount);
            this.Controls.Add(this.Dequeue);
            this.Controls.Add(this.Enqueue);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.AmountOwed_Label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.Display_Info);
            this.Controls.Add(this.AmountOwed_TextBox);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.Age_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label AmountOwed_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.TextBox Display_Info;
        private System.Windows.Forms.TextBox AmountOwed_TextBox;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.TextBox Age_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label CustomerCount;
        private System.Windows.Forms.Label Total_Owed_Label;
        private System.Windows.Forms.Label Customer_Max_Debt_Label;
        private System.Windows.Forms.Button Peek;
        private System.Windows.Forms.TextBox textBox1;
    }
}

