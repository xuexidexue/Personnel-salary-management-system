namespace 人事工资管理系统
{
    partial class 管理员主界面
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(管理员主界面));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.部门管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.薪酬管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加薪酬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.安全退出ToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.退出ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.时间});
            this.statusStrip1.Location = new System.Drawing.Point(156, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(548, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // 时间
            // 
            this.时间.BackColor = System.Drawing.SystemColors.Control;
            this.时间.ForeColor = System.Drawing.SystemColors.ControlText;
            this.时间.Name = "时间";
            this.时间.Size = new System.Drawing.Size(39, 20);
            this.时间.Text = "时间";
            // 
            // 部门管理ToolStripMenuItem
            // 
            this.部门管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem});
            this.部门管理ToolStripMenuItem.Name = "部门管理ToolStripMenuItem";
            this.部门管理ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.部门管理ToolStripMenuItem.Text = "部门管理";
            this.部门管理ToolStripMenuItem.Click += new System.EventHandler(this.部门管理ToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.添加ToolStripMenuItem.Text = "管理部门";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加员工ToolStripMenuItem});
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            this.员工管理ToolStripMenuItem.Click += new System.EventHandler(this.员工管理ToolStripMenuItem_Click);
            // 
            // 添加员工ToolStripMenuItem
            // 
            this.添加员工ToolStripMenuItem.Name = "添加员工ToolStripMenuItem";
            this.添加员工ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.添加员工ToolStripMenuItem.Text = "管理员工";
            this.添加员工ToolStripMenuItem.Click += new System.EventHandler(this.添加员工ToolStripMenuItem_Click);
            // 
            // 薪酬管理ToolStripMenuItem
            // 
            this.薪酬管理ToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.薪酬管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加薪酬ToolStripMenuItem});
            this.薪酬管理ToolStripMenuItem.Name = "薪酬管理ToolStripMenuItem";
            this.薪酬管理ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.薪酬管理ToolStripMenuItem.Text = "工资管理";
            this.薪酬管理ToolStripMenuItem.Click += new System.EventHandler(this.薪酬管理ToolStripMenuItem_Click);
            // 
            // 添加薪酬ToolStripMenuItem
            // 
            this.添加薪酬ToolStripMenuItem.Name = "添加薪酬ToolStripMenuItem";
            this.添加薪酬ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.添加薪酬ToolStripMenuItem.Text = "管理工资";
            this.添加薪酬ToolStripMenuItem.Click += new System.EventHandler(this.添加薪酬ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.修改密码ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(152, 26);
            this.toolStripComboBox1.Text = "管理用户";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者ToolStripMenuItem,
            this.toolStripSeparator1});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(143, 24);
            this.toolStripMenuItem7.Text = "关于";
            // 
            // 作者ToolStripMenuItem
            // 
            this.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem";
            this.作者ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.作者ToolStripMenuItem.Text = "作者：";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.薪酬管理ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.toolStripMenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 424);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(132, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.安全退出ToolStripMenuItem,
            this.退出ToolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(704, 32);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 安全退出ToolStripMenuItem
            // 
            this.安全退出ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.安全退出ToolStripMenuItem.Name = "安全退出ToolStripMenuItem";
            this.安全退出ToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.安全退出ToolStripMenuItem.Text = "搜索";
            // 
            // 退出ToolStripMenuItem2
            // 
            this.退出ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem2.Image")));
            this.退出ToolStripMenuItem2.Name = "退出ToolStripMenuItem2";
            this.退出ToolStripMenuItem2.Size = new System.Drawing.Size(113, 28);
            this.退出ToolStripMenuItem2.Text = "退出（&X）";
            this.退出ToolStripMenuItem2.Click += new System.EventHandler(this.退出ToolStripMenuItem2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 管理员主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::人事工资管理系统.Properties.Resources.Annie_Splash_5;
            this.ClientSize = new System.Drawing.Size(704, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "管理员主界面";
            this.Text = "管理员主界面";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 部门管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 薪酬管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加薪酬ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 作者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel 时间;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox 安全退出ToolStripMenuItem;
    }
}