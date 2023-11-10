namespace CharTable
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            settingToolStripMenuItem = new ToolStripMenuItem();
            clearUseCountToolStripMenuItem = new ToolStripMenuItem();
            fontRightClickContextMenuStrip = new ContextMenuStrip(components);
            toolStripMenuItem_Copy = new ToolStripMenuItem();
            toolStripMenuItem_Mark = new ToolStripMenuItem();
            toolStripMenuItem_Edit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel_Info = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            checkBox_AutoSearch = new CheckBox();
            button_Search = new Button();
            textBox_Search = new TextBox();
            tabControl1 = new TabControl();
            menuStrip1.SuspendLayout();
            fontRightClickContextMenuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem, clearUseCountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(826, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(44, 21);
            settingToolStripMenuItem.Text = "设置";
            // 
            // clearUseCountToolStripMenuItem
            // 
            clearUseCountToolStripMenuItem.Name = "clearUseCountToolStripMenuItem";
            clearUseCountToolStripMenuItem.Size = new Size(92, 21);
            clearUseCountToolStripMenuItem.Text = "清空使用记录";
            clearUseCountToolStripMenuItem.Click += clearUseCountToolStripMenuItem_Click;
            // 
            // fontRightClickContextMenuStrip
            // 
            fontRightClickContextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_Copy, toolStripMenuItem_Mark, toolStripMenuItem_Edit });
            fontRightClickContextMenuStrip.Name = "fontRightClickContextMenuStrip";
            fontRightClickContextMenuStrip.Size = new Size(101, 70);
            fontRightClickContextMenuStrip.ItemClicked += fontRightClickContextMenuStrip_ItemClicked;
            // 
            // toolStripMenuItem_Copy
            // 
            toolStripMenuItem_Copy.Name = "toolStripMenuItem_Copy";
            toolStripMenuItem_Copy.Size = new Size(100, 22);
            toolStripMenuItem_Copy.Text = "复制";
            // 
            // toolStripMenuItem_Mark
            // 
            toolStripMenuItem_Mark.Name = "toolStripMenuItem_Mark";
            toolStripMenuItem_Mark.Size = new Size(100, 22);
            toolStripMenuItem_Mark.Text = "收藏";
            // 
            // toolStripMenuItem_Edit
            // 
            toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            toolStripMenuItem_Edit.Size = new Size(100, 22);
            toolStripMenuItem_Edit.Text = "编辑";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_Info });
            statusStrip1.Location = new Point(0, 442);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(826, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Info
            // 
            toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            toolStripStatusLabel_Info.Size = new Size(0, 17);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(checkBox_AutoSearch);
            splitContainer1.Panel1.Controls.Add(button_Search);
            splitContainer1.Panel1.Controls.Add(textBox_Search);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(826, 417);
            splitContainer1.SplitterDistance = 63;
            splitContainer1.TabIndex = 3;
            // 
            // checkBox_AutoSearch
            // 
            checkBox_AutoSearch.AutoSize = true;
            checkBox_AutoSearch.Location = new Point(696, 21);
            checkBox_AutoSearch.Name = "checkBox_AutoSearch";
            checkBox_AutoSearch.Size = new Size(75, 21);
            checkBox_AutoSearch.TabIndex = 5;
            checkBox_AutoSearch.Text = "自动搜索";
            checkBox_AutoSearch.UseVisualStyleBackColor = true;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(250, 19);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(47, 23);
            button_Search.TabIndex = 4;
            button_Search.Text = "搜索";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(29, 19);
            textBox_Search.MaxLength = 16;
            textBox_Search.Name = "textBox_Search";
            textBox_Search.PlaceholderText = "字符的读音";
            textBox_Search.Size = new Size(206, 23);
            textBox_Search.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(826, 350);
            tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 464);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "特殊字符表";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            fontRightClickContextMenuStrip.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ContextMenuStrip fontRightClickContextMenuStrip;
        private ToolStripMenuItem toolStripMenuItem_Copy;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private CheckBox checkBox_AutoSearch;
        private Button button_Search;
        private TextBox textBox_Search;
        private TabControl tabControl1;
        private ToolStripStatusLabel toolStripStatusLabel_Info;
        private ToolStripMenuItem toolStripMenuItem_Mark;
        private ToolStripMenuItem clearUseCountToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_Edit;
    }
}