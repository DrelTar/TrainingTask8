namespace WindowsFormsApp6
{
    partial class StorageForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.rightClickTreeViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addClassifierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassifierTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addClassifierButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addProductButton = new System.Windows.Forms.ToolStripMenuItem();
            this.changeClassifierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeClassifierTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.changeClassifierButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClassifierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productView = new System.Windows.Forms.DataGridView();
            this.userButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rightClickProductsViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.amountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amountTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminButton = new System.Windows.Forms.Button();
            this.rightClickTreeViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            this.rightClickProductsViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(12, 33);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(213, 405);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
            // 
            // rightClickTreeViewMenu
            // 
            this.rightClickTreeViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickTreeViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassifierMenuItem,
            this.addProductMenuItem,
            this.changeClassifierMenuItem,
            this.deleteClassifierMenuItem});
            this.rightClickTreeViewMenu.Name = "contextMenuStrip1";
            this.rightClickTreeViewMenu.Size = new System.Drawing.Size(190, 100);
            // 
            // addClassifierMenuItem
            // 
            this.addClassifierMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassifierTextBox,
            this.addClassifierButton});
            this.addClassifierMenuItem.Name = "addClassifierMenuItem";
            this.addClassifierMenuItem.Size = new System.Drawing.Size(189, 24);
            this.addClassifierMenuItem.Text = "Add classifier";
            // 
            // addClassifierTextBox
            // 
            this.addClassifierTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addClassifierTextBox.Name = "addClassifierTextBox";
            this.addClassifierTextBox.Size = new System.Drawing.Size(100, 27);
            this.addClassifierTextBox.TextChanged += new System.EventHandler(this.addClassifierTextBox_TextChanged);
            // 
            // addClassifierButton
            // 
            this.addClassifierButton.Enabled = false;
            this.addClassifierButton.Name = "addClassifierButton";
            this.addClassifierButton.Size = new System.Drawing.Size(181, 26);
            this.addClassifierButton.Text = "Add classifier";
            this.addClassifierButton.Click += new System.EventHandler(this.addClassifierButton_Click);
            // 
            // addProductMenuItem
            // 
            this.addProductMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductTextBox,
            this.addProductButton});
            this.addProductMenuItem.Name = "addProductMenuItem";
            this.addProductMenuItem.Size = new System.Drawing.Size(189, 24);
            this.addProductMenuItem.Text = "Add product";
            // 
            // addProductTextBox
            // 
            this.addProductTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addProductTextBox.Name = "addProductTextBox";
            this.addProductTextBox.Size = new System.Drawing.Size(100, 27);
            this.addProductTextBox.TextChanged += new System.EventHandler(this.addProductTextBox_TextChanged);
            // 
            // addProductButton
            // 
            this.addProductButton.Enabled = false;
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(176, 26);
            this.addProductButton.Text = "Add product";
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // changeClassifierMenuItem
            // 
            this.changeClassifierMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeClassifierTextBox,
            this.changeClassifierButton});
            this.changeClassifierMenuItem.Name = "changeClassifierMenuItem";
            this.changeClassifierMenuItem.Size = new System.Drawing.Size(189, 24);
            this.changeClassifierMenuItem.Text = "Change classifier";
            // 
            // changeClassifierTextBox
            // 
            this.changeClassifierTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeClassifierTextBox.Name = "changeClassifierTextBox";
            this.changeClassifierTextBox.Size = new System.Drawing.Size(100, 27);
            this.changeClassifierTextBox.TextChanged += new System.EventHandler(this.changeClassifierTextBox_TextChanged);
            // 
            // changeClassifierButton
            // 
            this.changeClassifierButton.Enabled = false;
            this.changeClassifierButton.Name = "changeClassifierButton";
            this.changeClassifierButton.Size = new System.Drawing.Size(203, 26);
            this.changeClassifierButton.Text = "Change classifier";
            this.changeClassifierButton.Click += new System.EventHandler(this.changeClassifierButton_Click);
            // 
            // deleteClassifierMenuItem
            // 
            this.deleteClassifierMenuItem.Enabled = false;
            this.deleteClassifierMenuItem.Name = "deleteClassifierMenuItem";
            this.deleteClassifierMenuItem.Size = new System.Drawing.Size(189, 24);
            this.deleteClassifierMenuItem.Text = "Delete classifier";
            this.deleteClassifierMenuItem.Click += new System.EventHandler(this.deleteClassifierMenuItem_Click);
            // 
            // productView
            // 
            this.productView.AllowUserToAddRows = false;
            this.productView.AllowUserToDeleteRows = false;
            this.productView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Location = new System.Drawing.Point(231, 12);
            this.productView.MultiSelect = false;
            this.productView.Name = "productView";
            this.productView.RowHeadersWidth = 51;
            this.productView.RowTemplate.Height = 24;
            this.productView.Size = new System.Drawing.Size(557, 396);
            this.productView.TabIndex = 1;
            this.productView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productView_MouseClick);
            // 
            // userButton
            // 
            this.userButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userButton.Location = new System.Drawing.Point(534, 415);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 23);
            this.userButton.TabIndex = 6;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.Enabled = false;
            this.cartButton.Location = new System.Drawing.Point(616, 416);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(75, 23);
            this.cartButton.TabIndex = 7;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Visible = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(52, 9);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(40, 17);
            this.helloLabel.TabIndex = 8;
            this.helloLabel.Text = "Hello";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(112, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Guest";
            // 
            // rightClickProductsViewMenu
            // 
            this.rightClickProductsViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickProductsViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amountMenuItem,
            this.amountTextBox,
            this.addMenuItem,
            this.closeOrderMenuItem});
            this.rightClickProductsViewMenu.Name = "rightClickProductsTableMenu";
            this.rightClickProductsViewMenu.Size = new System.Drawing.Size(268, 105);
            // 
            // amountMenuItem
            // 
            this.amountMenuItem.Name = "amountMenuItem";
            this.amountMenuItem.Size = new System.Drawing.Size(267, 24);
            this.amountMenuItem.Text = "Amount of selected product:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 27);
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // addMenuItem
            // 
            this.addMenuItem.Enabled = false;
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(267, 24);
            this.addMenuItem.Text = "Add product";
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // closeOrderMenuItem
            // 
            this.closeOrderMenuItem.Enabled = false;
            this.closeOrderMenuItem.Name = "closeOrderMenuItem";
            this.closeOrderMenuItem.Size = new System.Drawing.Size(267, 24);
            this.closeOrderMenuItem.Text = "Close order";
            this.closeOrderMenuItem.Click += new System.EventHandler(this.closeOrderMenuItem_Click);
            // 
            // adminButton
            // 
            this.adminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminButton.Enabled = false;
            this.adminButton.Location = new System.Drawing.Point(698, 415);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 10;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.productView);
            this.Controls.Add(this.treeView);
            this.Name = "StorageForm";
            this.Text = "Form1";
            this.rightClickTreeViewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
            this.rightClickProductsViewMenu.ResumeLayout(false);
            this.rightClickProductsViewMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip rightClickTreeViewMenu;
        private System.Windows.Forms.ToolStripMenuItem addClassifierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductMenuItem;
        private System.Windows.Forms.ToolStripTextBox addClassifierTextBox;
        private System.Windows.Forms.ToolStripMenuItem addClassifierButton;
        private System.Windows.Forms.ToolStripTextBox addProductTextBox;
        private System.Windows.Forms.ToolStripMenuItem addProductButton;
        private System.Windows.Forms.ToolStripMenuItem changeClassifierMenuItem;
        private System.Windows.Forms.ToolStripTextBox changeClassifierTextBox;
        private System.Windows.Forms.ToolStripMenuItem changeClassifierButton;
        private System.Windows.Forms.ToolStripMenuItem deleteClassifierMenuItem;
        private System.Windows.Forms.DataGridView productView;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ContextMenuStrip rightClickProductsViewMenu;
        private System.Windows.Forms.ToolStripMenuItem amountMenuItem;
        private System.Windows.Forms.ToolStripTextBox amountTextBox;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeOrderMenuItem;
        private System.Windows.Forms.Button adminButton;
    }
}

