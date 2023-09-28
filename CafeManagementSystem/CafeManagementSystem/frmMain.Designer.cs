namespace CafeManagementSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFoodCategoryNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUpdateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryWiseItemInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodCategoryToolStripMenuItem,
            this.foodItemsToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // foodCategoryToolStripMenuItem
            // 
            this.foodCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allFoodCategoryNameToolStripMenuItem});
            this.foodCategoryToolStripMenuItem.Name = "foodCategoryToolStripMenuItem";
            this.foodCategoryToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.foodCategoryToolStripMenuItem.Text = "Food Category";
            // 
            // allFoodCategoryNameToolStripMenuItem
            // 
            this.allFoodCategoryNameToolStripMenuItem.Name = "allFoodCategoryNameToolStripMenuItem";
            this.allFoodCategoryNameToolStripMenuItem.Size = new System.Drawing.Size(296, 30);
            this.allFoodCategoryNameToolStripMenuItem.Text = "All Food Category Name";
            this.allFoodCategoryNameToolStripMenuItem.Click += new System.EventHandler(this.allFoodCategoryNameToolStripMenuItem_Click);
            // 
            // foodItemsToolStripMenuItem
            // 
            this.foodItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEntryToolStripMenuItem,
            this.itemUpdateDeleteToolStripMenuItem,
            this.itemsViewToolStripMenuItem});
            this.foodItemsToolStripMenuItem.Name = "foodItemsToolStripMenuItem";
            this.foodItemsToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.foodItemsToolStripMenuItem.Text = "Food Items";
            // 
            // itemEntryToolStripMenuItem
            // 
            this.itemEntryToolStripMenuItem.Name = "itemEntryToolStripMenuItem";
            this.itemEntryToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.itemEntryToolStripMenuItem.Text = "Item Entry";
            this.itemEntryToolStripMenuItem.Click += new System.EventHandler(this.itemEntryToolStripMenuItem_Click);
            // 
            // itemUpdateDeleteToolStripMenuItem
            // 
            this.itemUpdateDeleteToolStripMenuItem.Name = "itemUpdateDeleteToolStripMenuItem";
            this.itemUpdateDeleteToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.itemUpdateDeleteToolStripMenuItem.Text = "Item Update/Delete";
            this.itemUpdateDeleteToolStripMenuItem.Click += new System.EventHandler(this.itemUpdateDeleteToolStripMenuItem_Click);
            // 
            // itemsViewToolStripMenuItem
            // 
            this.itemsViewToolStripMenuItem.Name = "itemsViewToolStripMenuItem";
            this.itemsViewToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.itemsViewToolStripMenuItem.Text = "Items View";
            this.itemsViewToolStripMenuItem.Click += new System.EventHandler(this.itemsViewToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemInformationReportToolStripMenuItem,
            this.categoryWiseItemInformationReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // itemInformationReportToolStripMenuItem
            // 
            this.itemInformationReportToolStripMenuItem.Name = "itemInformationReportToolStripMenuItem";
            this.itemInformationReportToolStripMenuItem.Size = new System.Drawing.Size(436, 30);
            this.itemInformationReportToolStripMenuItem.Text = "Item Information Report";
            // 
            // categoryWiseItemInformationReportToolStripMenuItem
            // 
            this.categoryWiseItemInformationReportToolStripMenuItem.Name = "categoryWiseItemInformationReportToolStripMenuItem";
            this.categoryWiseItemInformationReportToolStripMenuItem.Size = new System.Drawing.Size(436, 30);
            this.categoryWiseItemInformationReportToolStripMenuItem.Text = "Category Wise Item Information Report";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFoodCategoryNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemUpdateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemInformationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryWiseItemInformationReportToolStripMenuItem;
    }
}