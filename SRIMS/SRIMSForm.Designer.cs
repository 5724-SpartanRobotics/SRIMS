namespace SRIMS
{
    partial class SRIMSForm
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
			this.sidePanel = new System.Windows.Forms.Panel();
			this._PanelCategoriesSelected = new System.Windows.Forms.Panel();
			this._BtnCategories = new System.Windows.Forms.Button();
			this.AddItemSelected = new System.Windows.Forms.Panel();
			this.SearchSelected = new System.Windows.Forms.Panel();
			this.ViewDatabaseSelected = new System.Windows.Forms.Panel();
			this.CheckInSelected = new System.Windows.Forms.Panel();
			this._BtnSettings = new System.Windows.Forms.Button();
			this._BtnAddItemPage = new System.Windows.Forms.Button();
			this._BtnSearchPage = new System.Windows.Forms.Button();
			this._BtnViewDBPage = new System.Windows.Forms.Button();
			this._BtnCheckInPage = new System.Windows.Forms.Button();
			this.CheckOutLogSelected = new System.Windows.Forms.Panel();
			this._BtnCheckOutLog = new System.Windows.Forms.Button();
			this.checkoutLog1 = new SRIMS.CheckoutLog();
			this.search1 = new SRIMS.SearchControl();
			this.addItem1 = new SRIMS.AddItem();
			this._ViewDB = new SRIMS.ViewDB();
			this._CategoryPage = new SRIMS.CategoryPage();
			this.checkin1 = new SRIMS.Checkin();
			this.sidePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// sidePanel
			// 
			this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.sidePanel.Controls.Add(this._PanelCategoriesSelected);
			this.sidePanel.Controls.Add(this._BtnCategories);
			this.sidePanel.Controls.Add(this.AddItemSelected);
			this.sidePanel.Controls.Add(this.SearchSelected);
			this.sidePanel.Controls.Add(this.ViewDatabaseSelected);
			this.sidePanel.Controls.Add(this.CheckInSelected);
			this.sidePanel.Controls.Add(this._BtnSettings);
			this.sidePanel.Controls.Add(this._BtnAddItemPage);
			this.sidePanel.Controls.Add(this._BtnSearchPage);
			this.sidePanel.Controls.Add(this._BtnViewDBPage);
			this.sidePanel.Controls.Add(this._BtnCheckInPage);
			this.sidePanel.Controls.Add(this.CheckOutLogSelected);
			this.sidePanel.Controls.Add(this._BtnCheckOutLog);
			this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidePanel.Location = new System.Drawing.Point(0, 0);
			this.sidePanel.Name = "sidePanel";
			this.sidePanel.Size = new System.Drawing.Size(203, 526);
			this.sidePanel.TabIndex = 0;
			// 
			// _PanelCategoriesSelected
			// 
			this._PanelCategoriesSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this._PanelCategoriesSelected.Location = new System.Drawing.Point(3, 312);
			this._PanelCategoriesSelected.Name = "_PanelCategoriesSelected";
			this._PanelCategoriesSelected.Size = new System.Drawing.Size(10, 69);
			this._PanelCategoriesSelected.TabIndex = 6;
			this._PanelCategoriesSelected.Visible = false;
			// 
			// _BtnCategories
			// 
			this._BtnCategories.FlatAppearance.BorderSize = 0;
			this._BtnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnCategories.ForeColor = System.Drawing.Color.White;
			this._BtnCategories.Location = new System.Drawing.Point(3, 312);
			this._BtnCategories.Name = "_BtnCategories";
			this._BtnCategories.Size = new System.Drawing.Size(197, 69);
			this._BtnCategories.TabIndex = 7;
			this._BtnCategories.Text = "Categories";
			this._BtnCategories.UseVisualStyleBackColor = true;
			this._BtnCategories.Click += new System.EventHandler(this._BtnCategories_Click);
			// 
			// AddItemSelected
			// 
			this.AddItemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.AddItemSelected.Location = new System.Drawing.Point(3, 237);
			this.AddItemSelected.Name = "AddItemSelected";
			this.AddItemSelected.Size = new System.Drawing.Size(10, 69);
			this.AddItemSelected.TabIndex = 2;
			this.AddItemSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckOutLogPanel_Paint);
			// 
			// SearchSelected
			// 
			this.SearchSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.SearchSelected.Location = new System.Drawing.Point(3, 162);
			this.SearchSelected.Name = "SearchSelected";
			this.SearchSelected.Size = new System.Drawing.Size(10, 69);
			this.SearchSelected.TabIndex = 2;
			this.SearchSelected.Visible = false;
			this.SearchSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckOutLogPanel_Paint);
			// 
			// ViewDatabaseSelected
			// 
			this.ViewDatabaseSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.ViewDatabaseSelected.Location = new System.Drawing.Point(3, 87);
			this.ViewDatabaseSelected.Name = "ViewDatabaseSelected";
			this.ViewDatabaseSelected.Size = new System.Drawing.Size(10, 69);
			this.ViewDatabaseSelected.TabIndex = 2;
			this.ViewDatabaseSelected.Visible = false;
			this.ViewDatabaseSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckOutLogPanel_Paint);
			// 
			// CheckInSelected
			// 
			this.CheckInSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.CheckInSelected.Location = new System.Drawing.Point(3, 12);
			this.CheckInSelected.Name = "CheckInSelected";
			this.CheckInSelected.Size = new System.Drawing.Size(10, 69);
			this.CheckInSelected.TabIndex = 2;
			this.CheckInSelected.Visible = false;
			this.CheckInSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckOutLogPanel_Paint);
			// 
			// _BtnSettings
			// 
			this._BtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._BtnSettings.FlatAppearance.BorderSize = 0;
			this._BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnSettings.ForeColor = System.Drawing.Color.White;
			this._BtnSettings.Location = new System.Drawing.Point(3, 478);
			this._BtnSettings.Name = "_BtnSettings";
			this._BtnSettings.Size = new System.Drawing.Size(197, 36);
			this._BtnSettings.TabIndex = 5;
			this._BtnSettings.Text = "Settings";
			this._BtnSettings.UseVisualStyleBackColor = true;
			this._BtnSettings.Click += new System.EventHandler(this._BtnSettings_Click);
			// 
			// _BtnAddItemPage
			// 
			this._BtnAddItemPage.FlatAppearance.BorderSize = 0;
			this._BtnAddItemPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnAddItemPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnAddItemPage.ForeColor = System.Drawing.Color.White;
			this._BtnAddItemPage.Location = new System.Drawing.Point(3, 237);
			this._BtnAddItemPage.Name = "_BtnAddItemPage";
			this._BtnAddItemPage.Size = new System.Drawing.Size(197, 69);
			this._BtnAddItemPage.TabIndex = 3;
			this._BtnAddItemPage.Text = "Add Item";
			this._BtnAddItemPage.UseVisualStyleBackColor = true;
			this._BtnAddItemPage.Click += new System.EventHandler(this._BtnAddItemPage_Click);
			// 
			// _BtnSearchPage
			// 
			this._BtnSearchPage.FlatAppearance.BorderSize = 0;
			this._BtnSearchPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnSearchPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnSearchPage.ForeColor = System.Drawing.Color.White;
			this._BtnSearchPage.Location = new System.Drawing.Point(3, 162);
			this._BtnSearchPage.Name = "_BtnSearchPage";
			this._BtnSearchPage.Size = new System.Drawing.Size(197, 69);
			this._BtnSearchPage.TabIndex = 2;
			this._BtnSearchPage.Text = "Search";
			this._BtnSearchPage.UseVisualStyleBackColor = true;
			this._BtnSearchPage.Click += new System.EventHandler(this._BtnSearchPage_Click);
			// 
			// _BtnViewDBPage
			// 
			this._BtnViewDBPage.FlatAppearance.BorderSize = 0;
			this._BtnViewDBPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnViewDBPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnViewDBPage.ForeColor = System.Drawing.Color.White;
			this._BtnViewDBPage.Location = new System.Drawing.Point(3, 87);
			this._BtnViewDBPage.Name = "_BtnViewDBPage";
			this._BtnViewDBPage.Size = new System.Drawing.Size(197, 69);
			this._BtnViewDBPage.TabIndex = 1;
			this._BtnViewDBPage.Text = "View Database";
			this._BtnViewDBPage.UseVisualStyleBackColor = true;
			this._BtnViewDBPage.Click += new System.EventHandler(this._BtnViewDBPage_Click);
			// 
			// _BtnCheckInPage
			// 
			this._BtnCheckInPage.FlatAppearance.BorderSize = 0;
			this._BtnCheckInPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnCheckInPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnCheckInPage.ForeColor = System.Drawing.Color.White;
			this._BtnCheckInPage.Location = new System.Drawing.Point(3, 12);
			this._BtnCheckInPage.Name = "_BtnCheckInPage";
			this._BtnCheckInPage.Size = new System.Drawing.Size(197, 69);
			this._BtnCheckInPage.TabIndex = 0;
			this._BtnCheckInPage.Text = "Check In";
			this._BtnCheckInPage.UseVisualStyleBackColor = true;
			this._BtnCheckInPage.Click += new System.EventHandler(this._BtnCheckInPage_Click);
			// 
			// CheckOutLogSelected
			// 
			this.CheckOutLogSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.CheckOutLogSelected.Location = new System.Drawing.Point(3, 387);
			this.CheckOutLogSelected.Name = "CheckOutLogSelected";
			this.CheckOutLogSelected.Size = new System.Drawing.Size(10, 69);
			this.CheckOutLogSelected.TabIndex = 2;
			this.CheckOutLogSelected.Visible = false;
			this.CheckOutLogSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckOutLogPanel_Paint);
			// 
			// _BtnCheckOutLog
			// 
			this._BtnCheckOutLog.FlatAppearance.BorderSize = 0;
			this._BtnCheckOutLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnCheckOutLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnCheckOutLog.ForeColor = System.Drawing.Color.White;
			this._BtnCheckOutLog.Location = new System.Drawing.Point(3, 387);
			this._BtnCheckOutLog.Name = "_BtnCheckOutLog";
			this._BtnCheckOutLog.Size = new System.Drawing.Size(197, 69);
			this._BtnCheckOutLog.TabIndex = 4;
			this._BtnCheckOutLog.Text = "CheckOut Log";
			this._BtnCheckOutLog.UseVisualStyleBackColor = true;
			this._BtnCheckOutLog.Visible = false;
			this._BtnCheckOutLog.Click += new System.EventHandler(this._BtnCheckOutLog_Click);
			// 
			// checkoutLog1
			// 
			this.checkoutLog1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.checkoutLog1.Dock = System.Windows.Forms.DockStyle.Right;
			this.checkoutLog1.Location = new System.Drawing.Point(204, 0);
			this.checkoutLog1.Name = "checkoutLog1";
			this.checkoutLog1.Size = new System.Drawing.Size(630, 526);
			this.checkoutLog1.TabIndex = 3;
			// 
			// search1
			// 
			this.search1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.search1.Location = new System.Drawing.Point(203, 0);
			this.search1.Name = "search1";
			this.search1.Size = new System.Drawing.Size(630, 526);
			this.search1.TabIndex = 2;
			// 
			// addItem1
			// 
			this.addItem1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addItem1.Location = new System.Drawing.Point(203, 0);
			this.addItem1.Name = "addItem1";
			this.addItem1.Size = new System.Drawing.Size(631, 526);
			this.addItem1.TabIndex = 1;
			// 
			// _ViewDB
			// 
			this._ViewDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._ViewDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._ViewDB.BackColor = System.Drawing.Color.White;
			this._ViewDB.Location = new System.Drawing.Point(203, 0);
			this._ViewDB.Name = "_ViewDB";
			this._ViewDB.Size = new System.Drawing.Size(630, 526);
			this._ViewDB.TabIndex = 4;
			// 
			// _CategoryPage
			// 
			this._CategoryPage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._CategoryPage.AutoSize = true;
			this._CategoryPage.Location = new System.Drawing.Point(203, 0);
			this._CategoryPage.Name = "_CategoryPage";
			this._CategoryPage.Size = new System.Drawing.Size(630, 526);
			this._CategoryPage.TabIndex = 6;
			// 
			// checkin1
			// 
			this.checkin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.checkin1.Location = new System.Drawing.Point(204, 0);
			this.checkin1.Name = "checkin1";
			this.checkin1.Size = new System.Drawing.Size(630, 526);
			this.checkin1.TabIndex = 5;
			// 
			// SRIMSForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 526);
			this.Controls.Add(this.sidePanel);
			this.Controls.Add(this.addItem1);
			this.Controls.Add(this.checkin1);
			this.Controls.Add(this.search1);
			this.Controls.Add(this._ViewDB);
			this.Controls.Add(this._CategoryPage);
			this.Controls.Add(this.checkoutLog1);
			this.MinimumSize = new System.Drawing.Size(850, 565);
			this.Name = "SRIMSForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Spartan Robotics Inventory Management System";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SRIMSForm_FormClosing);
			this.Load += new System.EventHandler(this.SRIMSForm_Load);
			this.sidePanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button _BtnCheckOutLog;
        private System.Windows.Forms.Button _BtnAddItemPage;
        private System.Windows.Forms.Button _BtnSearchPage;
        private System.Windows.Forms.Button _BtnViewDBPage;
        private System.Windows.Forms.Button _BtnCheckInPage;
        private System.Windows.Forms.Panel CheckOutLogSelected;
        private System.Windows.Forms.Panel AddItemSelected;
        private System.Windows.Forms.Panel SearchSelected;
        private System.Windows.Forms.Panel ViewDatabaseSelected;
        private System.Windows.Forms.Panel CheckInSelected;
        private System.Windows.Forms.Button _BtnSettings;
        private CheckoutLog checkoutLog1;
        private ViewDB _ViewDB;
		private System.Windows.Forms.Panel _PanelCategoriesSelected;
		private System.Windows.Forms.Button _BtnCategories;
		private CategoryPage _CategoryPage;
		private SearchControl search1;
		private AddItem addItem1;
		private Checkin checkin1;
	}
}

