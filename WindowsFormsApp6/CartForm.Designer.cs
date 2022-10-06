namespace WindowsFormsApp6
{
    partial class CartForm
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
            this.orderView = new System.Windows.Forms.DataGridView();
            this.rightClickOrderViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.payMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            this.rightClickOrderViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderView
            // 
            this.orderView.AllowUserToAddRows = false;
            this.orderView.AllowUserToDeleteRows = false;
            this.orderView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Location = new System.Drawing.Point(13, 13);
            this.orderView.MultiSelect = false;
            this.orderView.Name = "orderView";
            this.orderView.RowHeadersWidth = 51;
            this.orderView.RowTemplate.Height = 24;
            this.orderView.Size = new System.Drawing.Size(775, 425);
            this.orderView.TabIndex = 0;
            this.orderView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderView_MouseClick);
            // 
            // rightClickOrderViewMenu
            // 
            this.rightClickOrderViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickOrderViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payMenuItem});
            this.rightClickOrderViewMenu.Name = "rightClickOrderViewMenu";
            this.rightClickOrderViewMenu.Size = new System.Drawing.Size(101, 28);
            // 
            // payMenuItem
            // 
            this.payMenuItem.Enabled = false;
            this.payMenuItem.Name = "payMenuItem";
            this.payMenuItem.Size = new System.Drawing.Size(100, 24);
            this.payMenuItem.Text = "Pay";
            this.payMenuItem.Click += new System.EventHandler(this.payMenuItem_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderView);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            this.rightClickOrderViewMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView orderView;
        private System.Windows.Forms.ContextMenuStrip rightClickOrderViewMenu;
        public System.Windows.Forms.ToolStripMenuItem payMenuItem;
    }
}