namespace SRIMS
{
	partial class ViewDB
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
			this._BtnDelItem = new System.Windows.Forms.Button();
			this._BtnEdit = new System.Windows.Forms.Button();
			this._BtnOpenDatabase = new System.Windows.Forms.Button();
			this._ListViewBox = new SRIMS.SortableListView();
			this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.locColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.catColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.qtAvailableColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.qtTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// _BtnDelItem
			// 
			this._BtnDelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._BtnDelItem.BackColor = System.Drawing.Color.White;
			this._BtnDelItem.FlatAppearance.BorderSize = 0;
			this._BtnDelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnDelItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnDelItem.Location = new System.Drawing.Point(597, 3);
			this._BtnDelItem.Name = "_BtnDelItem";
			this._BtnDelItem.Size = new System.Drawing.Size(30, 30);
			this._BtnDelItem.TabIndex = 8;
			this._BtnDelItem.Text = "X";
			this._BtnDelItem.UseVisualStyleBackColor = false;
			this._BtnDelItem.Click += new System.EventHandler(this._BtnDelItem_Click);
			// 
			// _BtnEdit
			// 
			this._BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._BtnEdit.FlatAppearance.BorderSize = 0;
			this._BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnEdit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnEdit.Location = new System.Drawing.Point(516, 3);
			this._BtnEdit.Name = "_BtnEdit";
			this._BtnEdit.Size = new System.Drawing.Size(75, 30);
			this._BtnEdit.TabIndex = 7;
			this._BtnEdit.Text = "Edit";
			this._BtnEdit.UseVisualStyleBackColor = true;
			this._BtnEdit.Click += new System.EventHandler(this._BtnEdit_Click);
			// 
			// _BtnOpenDatabase
			// 
			this._BtnOpenDatabase.FlatAppearance.BorderSize = 0;
			this._BtnOpenDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnOpenDatabase.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnOpenDatabase.Location = new System.Drawing.Point(3, 3);
			this._BtnOpenDatabase.Name = "_BtnOpenDatabase";
			this._BtnOpenDatabase.Size = new System.Drawing.Size(142, 30);
			this._BtnOpenDatabase.TabIndex = 6;
			this._BtnOpenDatabase.Text = "Open Database";
			this._BtnOpenDatabase.UseVisualStyleBackColor = true;
			this._BtnOpenDatabase.Click += new System.EventHandler(this._BtnOpenDatabase_Click);
			// 
			// _ListViewBox
			// 
			this._ListViewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._ListViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.locColumn,
            this.catColumn,
            this.nameColumn,
            this.descColumn,
            this.qtAvailableColumn,
            this.qtTotalColumn});
			this._ListViewBox.FullRowSelect = true;
			this._ListViewBox.Location = new System.Drawing.Point(3, 39);
			this._ListViewBox.MultiSelect = false;
			this._ListViewBox.Name = "_ListViewBox";
			this._ListViewBox.ShowItemToolTips = true;
			this._ListViewBox.Size = new System.Drawing.Size(624, 484);
			this._ListViewBox.TabIndex = 9;
			this._ListViewBox.UseCompatibleStateImageBehavior = false;
			this._ListViewBox.View = System.Windows.Forms.View.Details;
			this._ListViewBox.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this._ListViewBox_ColumnWidthChanged);
			this._ListViewBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._ListViewBox_MouseDoubleClick);
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
			this.catColumn.Width = 70;
			// 
			// nameColumn
			// 
			this.nameColumn.Text = "Item";
			this.nameColumn.Width = 112;
			// 
			// descColumn
			// 
			this.descColumn.Text = "Description";
			this.descColumn.Width = 310;
			// 
			// qtAvailableColumn
			// 
			this.qtAvailableColumn.Text = "Qt. Available";
			this.qtAvailableColumn.Width = 51;
			// 
			// qtTotalColumn
			// 
			this.qtTotalColumn.Text = "Qt. Total";
			// 
			// ViewDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this._ListViewBox);
			this.Controls.Add(this._BtnOpenDatabase);
			this.Controls.Add(this._BtnEdit);
			this.Controls.Add(this._BtnDelItem);
			this.Name = "ViewDB";
			this.Size = new System.Drawing.Size(630, 526);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button _BtnDelItem;
		private System.Windows.Forms.Button _BtnEdit;
		private System.Windows.Forms.Button _BtnOpenDatabase;
		private SRIMS.SortableListView _ListViewBox;
		private System.Windows.Forms.ColumnHeader idColumn;
		private System.Windows.Forms.ColumnHeader locColumn;
		private System.Windows.Forms.ColumnHeader catColumn;
		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.ColumnHeader descColumn;
		private System.Windows.Forms.ColumnHeader qtAvailableColumn;
		private System.Windows.Forms.ColumnHeader qtTotalColumn;
	}
}
