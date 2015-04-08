namespace Practice1
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
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PlayerTextBox2 = new System.Windows.Forms.TextBox();
            this.PlayerTextBox3 = new System.Windows.Forms.TextBox();
            this.PlayerTextBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Location = new System.Drawing.Point(12, 210);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.Size = new System.Drawing.Size(659, 173);
            this.MessageRichTextBox.TabIndex = 0;
            this.MessageRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 165);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerTextBox1
            // 
            this.PlayerTextBox1.Location = new System.Drawing.Point(38, 128);
            this.PlayerTextBox1.Multiline = true;
            this.PlayerTextBox1.Name = "PlayerTextBox1";
            this.PlayerTextBox1.ReadOnly = true;
            this.PlayerTextBox1.Size = new System.Drawing.Size(137, 73);
            this.PlayerTextBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practice1.Properties.Resources.熊大;
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Practice1.Properties.Resources.詹姆士;
            this.pictureBox2.Location = new System.Drawing.Point(227, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Practice1.Properties.Resources.兔兔;
            this.pictureBox3.Location = new System.Drawing.Point(423, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Practice1.Properties.Resources.莎莉;
            this.pictureBox4.Location = new System.Drawing.Point(607, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // PlayerTextBox2
            // 
            this.PlayerTextBox2.Location = new System.Drawing.Point(226, 128);
            this.PlayerTextBox2.Multiline = true;
            this.PlayerTextBox2.Name = "PlayerTextBox2";
            this.PlayerTextBox2.ReadOnly = true;
            this.PlayerTextBox2.Size = new System.Drawing.Size(133, 73);
            this.PlayerTextBox2.TabIndex = 10;
            // 
            // PlayerTextBox3
            // 
            this.PlayerTextBox3.Location = new System.Drawing.Point(422, 128);
            this.PlayerTextBox3.Multiline = true;
            this.PlayerTextBox3.Name = "PlayerTextBox3";
            this.PlayerTextBox3.ReadOnly = true;
            this.PlayerTextBox3.Size = new System.Drawing.Size(133, 73);
            this.PlayerTextBox3.TabIndex = 11;
            // 
            // PlayerTextBox4
            // 
            this.PlayerTextBox4.Location = new System.Drawing.Point(606, 128);
            this.PlayerTextBox4.Multiline = true;
            this.PlayerTextBox4.Name = "PlayerTextBox4";
            this.PlayerTextBox4.ReadOnly = true;
            this.PlayerTextBox4.Size = new System.Drawing.Size(133, 73);
            this.PlayerTextBox4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 415);
            this.Controls.Add(this.PlayerTextBox4);
            this.Controls.Add(this.PlayerTextBox3);
            this.Controls.Add(this.PlayerTextBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayerTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MessageRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PlayerTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox PlayerTextBox2;
        private System.Windows.Forms.TextBox PlayerTextBox3;
        private System.Windows.Forms.TextBox PlayerTextBox4;
    }
}

