namespace StoreManaSystem2
{
    partial class MainWin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日常业务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询统计管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.过期商品查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息管理ToolStripMenuItem,
            this.日常业务管理ToolStripMenuItem,
            this.查询统计管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息管理ToolStripMenuItem
            // 
            this.基础信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品信息管理ToolStripMenuItem,
            this.客户信息管理ToolStripMenuItem,
            this.供应商信息管理ToolStripMenuItem});
            this.基础信息管理ToolStripMenuItem.Name = "基础信息管理ToolStripMenuItem";
            this.基础信息管理ToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.基础信息管理ToolStripMenuItem.Text = "基础信息管理(B)";
            // 
            // 商品信息管理ToolStripMenuItem
            // 
            this.商品信息管理ToolStripMenuItem.Name = "商品信息管理ToolStripMenuItem";
            this.商品信息管理ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.商品信息管理ToolStripMenuItem.Text = "商品信息管理";
            this.商品信息管理ToolStripMenuItem.Click += new System.EventHandler(this.商品信息管理ToolStripMenuItem_Click);
            // 
            // 客户信息管理ToolStripMenuItem
            // 
            this.客户信息管理ToolStripMenuItem.Name = "客户信息管理ToolStripMenuItem";
            this.客户信息管理ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.客户信息管理ToolStripMenuItem.Text = "客户信息管理";
            this.客户信息管理ToolStripMenuItem.Click += new System.EventHandler(this.客户信息管理ToolStripMenuItem_Click);
            // 
            // 供应商信息管理ToolStripMenuItem
            // 
            this.供应商信息管理ToolStripMenuItem.Name = "供应商信息管理ToolStripMenuItem";
            this.供应商信息管理ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.供应商信息管理ToolStripMenuItem.Text = "供应商信息管理";
            this.供应商信息管理ToolStripMenuItem.Click += new System.EventHandler(this.供应商信息管理ToolStripMenuItem_Click);
            // 
            // 日常业务管理ToolStripMenuItem
            // 
            this.日常业务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem});
            this.日常业务管理ToolStripMenuItem.Name = "日常业务管理ToolStripMenuItem";
            this.日常业务管理ToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.日常业务管理ToolStripMenuItem.Text = "日常业务管理(R)";
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.入库管理ToolStripMenuItem.Text = "入库管理";
            this.入库管理ToolStripMenuItem.Click += new System.EventHandler(this.入库管理ToolStripMenuItem_Click);
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.出库管理ToolStripMenuItem.Text = "出库管理";
            this.出库管理ToolStripMenuItem.Click += new System.EventHandler(this.出库管理ToolStripMenuItem_Click);
            // 
            // 查询统计管理ToolStripMenuItem
            // 
            this.查询统计管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存查询ToolStripMenuItem,
            this.过期商品查询ToolStripMenuItem});
            this.查询统计管理ToolStripMenuItem.Name = "查询统计管理ToolStripMenuItem";
            this.查询统计管理ToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.查询统计管理ToolStripMenuItem.Text = "查询统计管理(O)";
            // 
            // 库存查询ToolStripMenuItem
            // 
            this.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem";
            this.库存查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.库存查询ToolStripMenuItem.Text = "库存查询";
            this.库存查询ToolStripMenuItem.Click += new System.EventHandler(this.库存查询ToolStripMenuItem_Click);
            // 
            // 过期商品查询ToolStripMenuItem
            // 
            this.过期商品查询ToolStripMenuItem.Name = "过期商品查询ToolStripMenuItem";
            this.过期商品查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.过期商品查询ToolStripMenuItem.Text = "过期商品查询";
            this.过期商品查询ToolStripMenuItem.Click += new System.EventHandler(this.过期商品查询ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理(S)";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.用户管理ToolStripMenuItem.Text = "用户信息管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "欢迎使用YK商店管理系统1.0";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWin";
            this.Text = "MainWin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日常业务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询统计管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 过期商品查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}