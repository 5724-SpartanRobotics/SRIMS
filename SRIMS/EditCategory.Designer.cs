namespace SRIMS
{
	partial class EditCategory
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
			this._BtnSave = new System.Windows.Forms.Button();
			this._TextBoxCategoryName = new System.Windows.Forms.TextBox();
			this._BtnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _BtnSave
			// 
			this._BtnSave.Location = new System.Drawing.Point(9, 53);
			this._BtnSave.Name = "_BtnSave";
			this._BtnSave.Size = new System.Drawing.Size(75, 23);
			this._BtnSave.TabIndex = 0;
			this._BtnSave.Text = "Save";
			this._BtnSave.UseVisualStyleBackColor = true;
			this._BtnSave.Click += new System.EventHandler(this._BtnSave_Click);
			// 
			// _TextBoxCategoryName
			// 
			this._TextBoxCategoryName.Location = new System.Drawing.Point(9, 27);
			this._TextBoxCategoryName.Name = "_TextBoxCategoryName";
			this._TextBoxCategoryName.Size = new System.Drawing.Size(156, 20);
			this._TextBoxCategoryName.TabIndex = 1;
			// 
			// _BtnCancel
			// 
			this._BtnCancel.Location = new System.Drawing.Point(90, 53);
			this._BtnCancel.Name = "_BtnCancel";
			this._BtnCancel.Size = new System.Drawing.Size(75, 23);
			this._BtnCancel.TabIndex = 2;
			this._BtnCancel.Text = "Cancel";
			this._BtnCancel.UseVisualStyleBackColor = true;
			this._BtnCancel.Click += new System.EventHandler(this._BtnCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Category Name:";
			// 
			// EditCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(177, 88);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._BtnCancel);
			this.Controls.Add(this._TextBoxCategoryName);
			this.Controls.Add(this._BtnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditCategory";
			this.Text = "EditCategory";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _BtnSave;
		private System.Windows.Forms.TextBox _TextBoxCategoryName;
		private System.Windows.Forms.Button _BtnCancel;
		private System.Windows.Forms.Label label1;
	}
}