namespace DockingWinForms.ViaDarkUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DemoMenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DemoToolStrip = new DarkUI.Controls.DarkToolStrip();
            this.DemoStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DemoStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DemoStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.DemoStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.DemoStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.DemoStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.DemoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DemoStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DemoStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.DemoStatusStrip = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.DemoDockPanel = new DarkUI.Docking.DarkDockPanel();
            this.DemoMenuStrip.SuspendLayout();
            this.DemoToolStrip.SuspendLayout();
            this.DemoStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DemoMenuStrip
            // 
            this.DemoMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DemoMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.DemoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DemoMenuStrip.Name = "DemoMenuStrip";
            this.DemoMenuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.DemoMenuStrip.ShowItemToolTips = true;
            this.DemoMenuStrip.Size = new System.Drawing.Size(800, 25);
            this.DemoMenuStrip.TabIndex = 0;
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文档ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.开始ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 新建文档ToolStripMenuItem
            // 
            this.新建文档ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.新建文档ToolStripMenuItem.Name = "新建文档ToolStripMenuItem";
            this.新建文档ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建文档ToolStripMenuItem.Text = "新建文档";
            this.新建文档ToolStripMenuItem.Click += new System.EventHandler(this.新建文档ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // DemoToolStrip
            // 
            this.DemoToolStrip.AllowItemReorder = true;
            this.DemoToolStrip.AutoSize = false;
            this.DemoToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DemoToolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DemoStripLabel1,
            this.DemoStripButton1,
            this.DemoStripButton2,
            this.DemoStripButton4,
            this.DemoStripButton3,
            this.DemoStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripComboBox2,
            this.toolStripTextBox2,
            this.toolStripProgressBar1});
            this.DemoToolStrip.Location = new System.Drawing.Point(0, 25);
            this.DemoToolStrip.Name = "DemoToolStrip";
            this.DemoToolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.DemoToolStrip.Size = new System.Drawing.Size(800, 25);
            this.DemoToolStrip.TabIndex = 1;
            this.DemoToolStrip.Text = "darkToolStrip1";
            // 
            // DemoStripLabel1
            // 
            this.DemoStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripLabel1.Name = "DemoStripLabel1";
            this.DemoStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.DemoStripLabel1.Text = "按钮:";
            // 
            // DemoStripButton1
            // 
            this.DemoStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DemoStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("DemoStripButton1.Image")));
            this.DemoStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DemoStripButton1.Name = "DemoStripButton1";
            this.DemoStripButton1.Size = new System.Drawing.Size(23, 22);
            this.DemoStripButton1.Text = "Button";
            // 
            // DemoStripButton2
            // 
            this.DemoStripButton2.CheckOnClick = true;
            this.DemoStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DemoStripButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("DemoStripButton2.Image")));
            this.DemoStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DemoStripButton2.Name = "DemoStripButton2";
            this.DemoStripButton2.Size = new System.Drawing.Size(23, 22);
            this.DemoStripButton2.Text = "Button";
            // 
            // DemoStripButton4
            // 
            this.DemoStripButton4.CheckOnClick = true;
            this.DemoStripButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("DemoStripButton4.Image")));
            this.DemoStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DemoStripButton4.Name = "DemoStripButton4";
            this.DemoStripButton4.Size = new System.Drawing.Size(66, 22);
            this.DemoStripButton4.Text = "Button";
            // 
            // DemoStripButton3
            // 
            this.DemoStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DemoStripButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("DemoStripButton3.Image")));
            this.DemoStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DemoStripButton3.Name = "DemoStripButton3";
            this.DemoStripButton3.Size = new System.Drawing.Size(50, 22);
            this.DemoStripButton3.Text = "Button";
            // 
            // DemoStripDropDownButton1
            // 
            this.DemoStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripTextBox1});
            this.DemoStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("DemoStripDropDownButton1.Image")));
            this.DemoStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DemoStripDropDownButton1.Name = "DemoStripDropDownButton1";
            this.DemoStripDropDownButton1.Size = new System.Drawing.Size(100, 22);
            this.DemoStripDropDownButton1.Text = "DropDown";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // DemoStripMenuItem1
            // 
            this.DemoStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripMenuItem1.Name = "DemoStripMenuItem1";
            this.DemoStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.DemoStripMenuItem1.Text = "菜单1";
            // 
            // DemoStripMenuItem2
            // 
            this.DemoStripMenuItem2.CheckOnClick = true;
            this.DemoStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripMenuItem2.Name = "DemoStripMenuItem2";
            this.DemoStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.DemoStripMenuItem2.Text = "菜单2";
            // 
            // DemoStripComboBox1
            // 
            this.DemoStripComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.DemoStripComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DemoStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DemoStripComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStripComboBox1.Name = "DemoStripComboBox1";
            this.DemoStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // DemoStatusStrip
            // 
            this.DemoStatusStrip.AutoSize = false;
            this.DemoStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DemoStatusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DemoStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar2,
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.DemoStatusStrip.Location = new System.Drawing.Point(0, 420);
            this.DemoStatusStrip.Name = "DemoStatusStrip";
            this.DemoStatusStrip.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.DemoStatusStrip.Size = new System.Drawing.Size(800, 30);
            this.DemoStatusStrip.SizingGrip = false;
            this.DemoStatusStrip.TabIndex = 2;
            this.DemoStatusStrip.Text = "darkStatusStrip1";
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripComboBox3,
            this.toolStripSeparator3,
            this.toolStripTextBox3});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // DemoDockPanel
            // 
            this.DemoDockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DemoDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DemoDockPanel.Location = new System.Drawing.Point(0, 50);
            this.DemoDockPanel.Name = "DemoDockPanel";
            this.DemoDockPanel.Size = new System.Drawing.Size(800, 370);
            this.DemoDockPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DemoDockPanel);
            this.Controls.Add(this.DemoStatusStrip);
            this.Controls.Add(this.DemoToolStrip);
            this.Controls.Add(this.DemoMenuStrip);
            this.MainMenuStrip = this.DemoMenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.DemoMenuStrip.ResumeLayout(false);
            this.DemoMenuStrip.PerformLayout();
            this.DemoToolStrip.ResumeLayout(false);
            this.DemoToolStrip.PerformLayout();
            this.DemoStatusStrip.ResumeLayout(false);
            this.DemoStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkMenuStrip DemoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private DarkUI.Controls.DarkToolStrip DemoToolStrip;
        private System.Windows.Forms.ToolStripButton DemoStripButton1;
        private System.Windows.Forms.ToolStripButton DemoStripButton2;
        private System.Windows.Forms.ToolStripButton DemoStripButton3;
        private System.Windows.Forms.ToolStripLabel DemoStripLabel1;
        private System.Windows.Forms.ToolStripButton DemoStripButton4;
        private System.Windows.Forms.ToolStripMenuItem DemoStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DemoStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox DemoStripComboBox1;
        private System.Windows.Forms.ToolStripDropDownButton DemoStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private DarkUI.Controls.DarkStatusStrip DemoStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private DarkUI.Docking.DarkDockPanel DemoDockPanel;
    }
}

