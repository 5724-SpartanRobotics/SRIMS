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
			this.SearchTypeDropdown = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.results = new System.Windows.Forms.ListView();
			this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.locColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.catColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.qtColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SearchBox = new SRIMS.SRIMSTextBox();
			this.SuspendLayout();
			// 
			// SearchTypeDropdown
			// 
			this.SearchTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SearchTypeDropdown.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchTypeDropdown.FormattingEnabled = true;
			this.SearchTypeDropdown.Items.AddRange(new object[] {
            "Name",
            "Location",
            "Category"});
			this.SearchTypeDropdown.Location = new System.Drawing.Point(63, 34);
			this.SearchTypeDropdown.Name = "SearchTypeDropdown";
			this.SearchTypeDropdown.Size = new System.Drawing.Size(142, 24);
			this.SearchTypeDropdown.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(442, 484);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 31);
			this.button2.TabIndex = 4;
			this.button2.Text = "Clear Results";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(184, 484);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 31);
			this.button3.TabIndex = 5;
			this.button3.Text = "Modify Selected";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Modify_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(63, 484);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(115, 31);
			this.button4.TabIndex = 5;
			this.button4.Text = "CheckOut Selected";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// results
			// 
			this.results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.locColumn,
            this.catColumn,
            this.nameColumn,
            this.descColumn,
            this.qtColumn});
			this.results.FullRowSelect = true;
			this.results.Location = new System.Drawing.Point(63, 66);
			this.results.MultiSelect = false;
			this.results.Name = "results";
			this.results.ShowItemToolTips = true;
			this.results.Size = new System.Drawing.Size(484, 412);
			this.results.TabIndex = 6;
			this.results.UseCompatibleStateImageBehavior = false;
			this.results.View = System.Windows.Forms.View.Details;
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
			// qtColumn
			// 
			this.qtColumn.Text = "Quantity";
			// 
			// SearchBox
			// 
			this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
			this.SearchBox.ForeColor = System.Drawing.Color.Black;
			this.SearchBox.Location = new System.Drawing.Point(211, 34);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(336, 21);
			this.SearchBox.TabIndex = 7;
			this.SearchBox.Text = "Search Argument";
			this.SearchBox.WatermarkActive = true;
			this.SearchBox.WatermarkColor = System.Drawing.Color.Gray;
			this.SearchBox.WatermarkText = "Search Argument";
			this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
			// 
			// SearchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SearchBox);
			this.Controls.Add(this.results);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.SearchTypeDropdown);
			this.Name = "SearchControl";
			this.Size = new System.Drawing.Size(630, 526);
			this.Load += new System.EventHandler(this.Search_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox SearchTypeDropdown;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListView results;
		private System.Windows.Forms.ColumnHeader idColumn;
		private System.Windows.Forms.ColumnHeader locColumn;
		private System.Windows.Forms.ColumnHeader catColumn;
		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.ColumnHeader descColumn;
		private System.Windows.Forms.ColumnHeader qtColumn;
		private SRIMSTextBox SearchBox;
	}
}
