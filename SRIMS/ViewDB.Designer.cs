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
			this.delitem = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.ViewListBox = new System.Windows.Forms.ListView();
			this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.locColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.catColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.qtColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// delitem
			// 
			this.delitem.BackColor = System.Drawing.Color.White;
			this.delitem.FlatAppearance.BorderSize = 0;
			this.delitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delitem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delitem.Location = new System.Drawing.Point(597, 3);
			this.delitem.Name = "delitem";
			this.delitem.Size = new System.Drawing.Size(30, 30);
			this.delitem.TabIndex = 1;
			this.delitem.Text = "X";
			this.delitem.UseVisualStyleBackColor = false;
			this.delitem.Click += new System.EventHandler(this.DelItem_Click);
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(516, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "Edit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(142, 30);
			this.button2.TabIndex = 2;
			this.button2.Text = "Open Database";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ViewListBox
			// 
			this.ViewListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.locColumn,
            this.catColumn,
            this.nameColumn,
            this.descColumn,
            this.qtColumn});
			this.ViewListBox.FullRowSelect = true;
			this.ViewListBox.Location = new System.Drawing.Point(3, 39);
			this.ViewListBox.MultiSelect = false;
			this.ViewListBox.Name = "ViewListBox";
			this.ViewListBox.ShowItemToolTips = true;
			this.ViewListBox.Size = new System.Drawing.Size(624, 484);
			this.ViewListBox.TabIndex = 7;
			this.ViewListBox.UseCompatibleStateImageBehavior = false;
			this.ViewListBox.View = System.Windows.Forms.View.Details;
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
			// qtColumn
			// 
			this.qtColumn.Text = "Quantity";
			this.qtColumn.Width = 51;
			// 
			// ViewDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.ViewListBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.delitem);
			this.Name = "ViewDB";
			this.Size = new System.Drawing.Size(630, 526);
			this.Load += new System.EventHandler(this.ViewDB_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button delitem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListView ViewListBox;
		private System.Windows.Forms.ColumnHeader idColumn;
		private System.Windows.Forms.ColumnHeader locColumn;
		private System.Windows.Forms.ColumnHeader catColumn;
		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.ColumnHeader descColumn;
		private System.Windows.Forms.ColumnHeader qtColumn;
	}
}
