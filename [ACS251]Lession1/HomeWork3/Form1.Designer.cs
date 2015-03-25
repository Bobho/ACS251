namespace HomeWork3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.ticketAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketComboBox = new System.Windows.Forms.ComboBox();
            this.ChildComboBox = new System.Windows.Forms.ComboBox();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(107, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "票種";
            // 
            // ticketAmountNumericUpDown
            // 
            this.ticketAmountNumericUpDown.Location = new System.Drawing.Point(457, 126);
            this.ticketAmountNumericUpDown.Name = "ticketAmountNumericUpDown";
            this.ticketAmountNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.ticketAmountNumericUpDown.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(455, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "數量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(455, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "兒童折扣方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(102, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "學生票折扣方式";
            // 
            // TicketComboBox
            // 
            this.TicketComboBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.TicketComboBox.FormattingEnabled = true;
            this.TicketComboBox.Location = new System.Drawing.Point(106, 120);
            this.TicketComboBox.Name = "TicketComboBox";
            this.TicketComboBox.Size = new System.Drawing.Size(305, 32);
            this.TicketComboBox.TabIndex = 25;
            // 
            // ChildComboBox
            // 
            this.ChildComboBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.ChildComboBox.FormattingEnabled = true;
            this.ChildComboBox.Location = new System.Drawing.Point(457, 46);
            this.ChildComboBox.Name = "ChildComboBox";
            this.ChildComboBox.Size = new System.Drawing.Size(305, 32);
            this.ChildComboBox.TabIndex = 24;
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(106, 46);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(305, 32);
            this.StudentComboBox.TabIndex = 23;
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.MessageRichTextBox.Location = new System.Drawing.Point(91, 181);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.Size = new System.Drawing.Size(671, 254);
            this.MessageRichTextBox.TabIndex = 22;
            this.MessageRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(587, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 64);
            this.button1.TabIndex = 21;
            this.button1.Text = "加入清單";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticketAmountNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TicketComboBox);
            this.Controls.Add(this.ChildComboBox);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.MessageRichTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ticketAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ticketAmountNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TicketComboBox;
        private System.Windows.Forms.ComboBox ChildComboBox;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.Button button1;
    }
}

