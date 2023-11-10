namespace CharTable
{
    partial class EditCharForm
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
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            button_Ok = new Button();
            button_Cancel = new Button();
            textBox_Char = new TextBox();
            textBox_Unicode = new TextBox();
            textBox_Keywords = new TextBox();
            textBox_UseCount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 80);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 2;
            label1.Text = "Unicode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 38);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 3;
            label2.Text = "字符";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 127);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 7;
            label3.Text = "关键字";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 170);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 9;
            label4.Text = "使用次数";
            // 
            // button_Ok
            // 
            button_Ok.DialogResult = DialogResult.OK;
            button_Ok.Location = new Point(355, 33);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(75, 23);
            button_Ok.TabIndex = 0;
            button_Ok.Text = "确定";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.DialogResult = DialogResult.Cancel;
            button_Cancel.Location = new Point(355, 77);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "取消";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // textBox_Char
            // 
            textBox_Char.Location = new Point(130, 32);
            textBox_Char.MaxLength = 1;
            textBox_Char.Name = "textBox_Char";
            textBox_Char.ReadOnly = true;
            textBox_Char.Size = new Size(146, 23);
            textBox_Char.TabIndex = 4;
            // 
            // textBox_Unicode
            // 
            textBox_Unicode.Location = new Point(130, 77);
            textBox_Unicode.MaxLength = 6;
            textBox_Unicode.Name = "textBox_Unicode";
            textBox_Unicode.ReadOnly = true;
            textBox_Unicode.Size = new Size(146, 23);
            textBox_Unicode.TabIndex = 5;
            // 
            // textBox_Keywords
            // 
            textBox_Keywords.Location = new Point(130, 124);
            textBox_Keywords.Name = "textBox_Keywords";
            textBox_Keywords.Size = new Size(146, 23);
            textBox_Keywords.TabIndex = 6;
            // 
            // textBox_UseCount
            // 
            textBox_UseCount.Location = new Point(130, 167);
            textBox_UseCount.MaxLength = 10;
            textBox_UseCount.Name = "textBox_UseCount";
            textBox_UseCount.Size = new Size(146, 23);
            textBox_UseCount.TabIndex = 8;
            // 
            // EditCharForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 236);
            Controls.Add(label4);
            Controls.Add(textBox_UseCount);
            Controls.Add(label3);
            Controls.Add(textBox_Keywords);
            Controls.Add(textBox_Unicode);
            Controls.Add(textBox_Char);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Cancel);
            Controls.Add(button_Ok);
            Name = "EditCharForm";
            Text = "编辑字符";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Ok;
        private Button button_Cancel;
        private Label label1;
        private Label label2;
        private TextBox textBox_Char;
        private TextBox textBox_Unicode;
        private TextBox textBox_Keywords;
        private Label label3;
        private TextBox textBox_UseCount;
    }
}