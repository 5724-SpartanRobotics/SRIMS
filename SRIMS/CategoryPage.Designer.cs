namespace SRIMS
{
	partial class CategoryPage
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
			this._BtnAddCategory = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this._LabelSuccess = new System.Windows.Forms.Label();
			this._TextBoxCategoryName = new SRIMS.WatermarkTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._BtnDeleteCategory = new System.Windows.Forms.Button();
			this._BtnRenameCategory = new System.Windows.Forms.Button();
			this._ListBoxCategories = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// _BtnAddCategory
			// 
			this._BtnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._BtnAddCategory.FlatAppearance.BorderSize = 0;
			this._BtnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnAddCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnAddCategory.ForeColor = System.Drawing.Color.White;
			this._BtnAddCategory.Location = new System.Drawing.Point(199, 369);
			this._BtnAddCategory.Name = "_BtnAddCategory";
			this._BtnAddCategory.Size = new System.Drawing.Size(223, 55);
			this._BtnAddCategory.TabIndex = 12;
			this._BtnAddCategory.Text = "Add Category";
			this._BtnAddCategory.UseVisualStyleBackColor = false;
			this._BtnAddCategory.Click += new System.EventHandler(this._BtnAddCategory_Click);
			// 
			// _LabelSuccess
			// 
			this._LabelSuccess.AutoSize = true;
			this._LabelSuccess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._LabelSuccess.Location = new System.Drawing.Point(185, 427);
			this._LabelSuccess.Name = "_LabelSuccess";
			this._LabelSuccess.Size = new System.Drawing.Size(249, 21);
			this._LabelSuccess.TabIndex = 4;
			this._LabelSuccess.Text = "Category Created Successfully";
			this._LabelSuccess.Visible = false;
			// 
			// _TextBoxCategoryName
			// 
			this._TextBoxCategoryName.Font = new System.Drawing.Font("Century Gothic", 12F);
			this._TextBoxCategoryName.ForeColor = System.Drawing.Color.Black;
			this._TextBoxCategoryName.Location = new System.Drawing.Point(199, 336);
			this._TextBoxCategoryName.Name = "_TextBoxCategoryName";
			this._TextBoxCategoryName.OriginalColor = System.Drawing.Color.Black;
			this._TextBoxCategoryName.Size = new System.Drawing.Size(223, 27);
			this._TextBoxCategoryName.TabIndex = 9;
			this._TextBoxCategoryName.Text = "Category Name";
			this._TextBoxCategoryName.WatermarkColor = System.Drawing.Color.Gray;
			this._TextBoxCategoryName.WatermarkText = "Category Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(195, 312);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 21);
			this.label2.TabIndex = 14;
			this.label2.Text = "Add a new category:";
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(195, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 15;
			this.label3.Text = "Categories:";
			this.label3.Visible = false;
			// 
			// _BtnDeleteCategory
			// 
			this._BtnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._BtnDeleteCategory.FlatAppearance.BorderSize = 0;
			this._BtnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnDeleteCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnDeleteCategory.ForeColor = System.Drawing.Color.Red;
			this._BtnDeleteCategory.Location = new System.Drawing.Point(199, 281);
			this._BtnDeleteCategory.Name = "_BtnDeleteCategory";
			this._BtnDeleteCategory.Size = new System.Drawing.Size(223, 28);
			this._BtnDeleteCategory.TabIndex = 16;
			this._BtnDeleteCategory.Text = "Delete Category";
			this._BtnDeleteCategory.UseVisualStyleBackColor = false;
			this._BtnDeleteCategory.Click += new System.EventHandler(this._BtnDeleteCategory_Click);
			// 
			// _BtnRenameCategory
			// 
			this._BtnRenameCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._BtnRenameCategory.FlatAppearance.BorderSize = 0;
			this._BtnRenameCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._BtnRenameCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._BtnRenameCategory.ForeColor = System.Drawing.Color.White;
			this._BtnRenameCategory.Location = new System.Drawing.Point(199, 247);
			this._BtnRenameCategory.Name = "_BtnRenameCategory";
			this._BtnRenameCategory.Size = new System.Drawing.Size(223, 28);
			this._BtnRenameCategory.TabIndex = 17;
			this._BtnRenameCategory.Text = "Rename Category";
			this._BtnRenameCategory.UseVisualStyleBackColor = false;
			this._BtnRenameCategory.Click += new System.EventHandler(this._BtnRenameCategory_Click);
			// 
			// _ListBoxCategories
			// 
			this._ListBoxCategories.FormattingEnabled = true;
			this._ListBoxCategories.Location = new System.Drawing.Point(199, 59);
			this._ListBoxCategories.Name = "_ListBoxCategories";
			this._ListBoxCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this._ListBoxCategories.Size = new System.Drawing.Size(223, 186);
			this._ListBoxCategories.TabIndex = 18;
			// 
			// CategoryPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._BtnRenameCategory);
			this.Controls.Add(this._BtnDeleteCategory);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._TextBoxCategoryName);
			this.Controls.Add(this._LabelSuccess);
			this.Controls.Add(this._BtnAddCategory);
			this.Controls.Add(this._ListBoxCategories);
			this.Name = "CategoryPage";
			this.Size = new System.Drawing.Size(630, 526);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button _BtnAddCategory;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label _LabelSuccess;
		private WatermarkTextbox _TextBoxCategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _BtnDeleteCategory;
		private System.Windows.Forms.Button _BtnRenameCategory;
		private System.Windows.Forms.ListBox _ListBoxCategories;
	}
}
