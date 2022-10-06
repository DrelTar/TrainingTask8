namespace WindowsFormsApp6
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.userOrderView = new System.Windows.Forms.DataGridView();
            this.userList = new System.Windows.Forms.ListBox();
            this.rightClickUserOrderViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.processedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.userOrderView)).BeginInit();
            this.rightClickUserOrderViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // userOrderView
            // 
            this.userOrderView.AllowUserToAddRows = false;
            this.userOrderView.AllowUserToDeleteRows = false;
            this.userOrderView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userOrderView.Location = new System.Drawing.Point(224, 12);
            this.userOrderView.Name = "userOrderView";
            this.userOrderView.RowHeadersWidth = 51;
            this.userOrderView.RowTemplate.Height = 24;
            this.userOrderView.Size = new System.Drawing.Size(564, 420);
            this.userOrderView.TabIndex = 1;
            this.userOrderView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userOrderView_MouseClick);
            // 
            // userList
            // 
            this.userList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(12, 12);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(206, 420);
            this.userList.TabIndex = 2;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // rightClickUserOrderViewMenu
            // 
            this.rightClickUserOrderViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickUserOrderViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processedMenuItem,
            this.shippedMenuItem,
            this.executedMenuItem});
            this.rightClickUserOrderViewMenu.Name = "rightClickUserOrderViewMenu";
            this.rightClickUserOrderViewMenu.Size = new System.Drawing.Size(145, 76);
            // 
            // processedMenuItem
            // 
            this.processedMenuItem.Name = "processedMenuItem";
            this.processedMenuItem.Size = new System.Drawing.Size(144, 24);
            this.processedMenuItem.Text = "Processed";
            this.processedMenuItem.Click += new System.EventHandler(this.processedMenuItem_Click);
            // 
            // shippedMenuItem
            // 
            this.shippedMenuItem.Name = "shippedMenuItem";
            this.shippedMenuItem.Size = new System.Drawing.Size(144, 24);
            this.shippedMenuItem.Text = "Shipped";
            this.shippedMenuItem.Click += new System.EventHandler(this.shippedMenuItem_Click);
            // 
            // executedMenuItem
            // 
            this.executedMenuItem.Name = "executedMenuItem";
            this.executedMenuItem.Size = new System.Drawing.Size(144, 24);
            this.executedMenuItem.Text = "Executed";
            this.executedMenuItem.Click += new System.EventHandler(this.executedMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.userOrderView);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userOrderView)).EndInit();
            this.rightClickUserOrderViewMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView userOrderView;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.ContextMenuStrip rightClickUserOrderViewMenu;
        public System.Windows.Forms.ToolStripMenuItem processedMenuItem;
        public System.Windows.Forms.ToolStripMenuItem shippedMenuItem;
        public System.Windows.Forms.ToolStripMenuItem executedMenuItem;
    }
}