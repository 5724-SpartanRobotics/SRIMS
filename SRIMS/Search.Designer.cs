namespace SRIMS
{
	partial class SearchControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SearchBox = new SRIMS.WatermarkTextbox();
			this._ListViewResults = new SRIMS.SortableListView();
			this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.locColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.catColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.qtAvailableColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.qtTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(522, 492);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 31);
			this.button2.TabIndex = 11;
			this.button2.Text = "Clear Search";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.ClearSearch_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(124, 492);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 31);
			this.button3.TabIndex = 10;
			this.button3.Text = "Modify Selected";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Modify_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(3, 492);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(115, 31);
			this.button4.TabIndex = 9;
			this.button4.Text = "CheckOut Selected";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this._Btn_Checkout_Click);
			// 
			// SearchBox
			// 
			this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
			this.SearchBox.ForeColor = System.Drawing.Color.Black;
			this.SearchBox.Location = new System.Drawing.Point(3, 3);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.OriginalColor = System.Drawing.Color.Black;
			this.SearchBox.Size = new System.Drawing.Size(624, 21);
			this.SearchBox.TabIndex = 7;
			this.SearchBox.Text = "Search Argument";
			this.SearchBox.WatermarkColor = System.Drawing.Color.Gray;
			this.SearchBox.WatermarkText = "Search Argument";
			this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
			// 
			// _ListViewResults
			// 
			this._ListViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._ListViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.locColumn,
            this.catColumn,
            this.nameColumn,
            this.descColumn,
            this.qtAvailableColumn,
            this.qtTotalColumn});
			this._ListViewResults.FullRowSelect = true;
			this._ListViewResults.Location = new System.Drawing.Point(3, 30);
			this._ListViewResults.MultiSelect = false;
			this._ListViewResults.Name = "_ListViewResults";
			this._ListViewResults.ShowItemToolTips = true;
			this._ListViewResults.Size = new System.Drawing.Size(624, 456);
			this._ListViewResults.TabIndex = 8;
			this._ListViewResults.UseCompatibleStateImageBehavior = false;
			this._ListViewResults.View = System.Windows.Forms.View.Details;
			this._ListViewResults.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this._ListViewResults_ColumnWidthChanged);
			this._ListViewResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._ListViewResults_MouseDoubleClick);
			// 
			// idColumn
			// 
			this.idColumn.Text = "ID";
			this.idColumn.Width = 23;
			// 
			// locColumn
			// 
			this.locColumn.Text = "Location";
			this.locColumn.Width = 53;
			// 
			// catColumn
			// 
			this.catColumn.Text = "Category";
			this.catColumn.Width = 64;
			// 
			// nameColumn
			// 
			this.nameColumn.Text = "Item";
			// 
			// descColumn
			// 
			this.descColumn.Text = "Description";
			// 
			// qtAvailableColumn
			// 
			this.qtAvailableColumn.Text = "Qt. Available";
			// 
			// qtTotalColumn
			// 
			this.qtTotalColumn.Text = "Qt. Total";
			// 
			// SearchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SearchBox);
			this.Controls.Add(this._ListViewResults);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Name = "SearchControl";
			this.Size = new System.Drawing.Size(630, 526);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private SRIMS.SortableListView _ListViewResults;
		private System.Windows.Forms.ColumnHeader idColumn;
		private System.Windows.Forms.ColumnHeader locColumn;
		private System.Windows.Forms.ColumnHeader catColumn;
		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.ColumnHeader descColumn;
		private System.Windows.Forms.ColumnHeader qtAvailableColumn;
		private WatermarkTextbox SearchBox;
		private System.Windows.Forms.ColumnHeader qtTotalColumn;
	}
}
