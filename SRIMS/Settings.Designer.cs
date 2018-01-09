namespace SRIMS
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.dbpath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ChangeDatabaseBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.CreateDatabaseBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dbpath
			// 
			this.dbpath.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dbpath.Location = new System.Drawing.Point(12, 50);
			this.dbpath.Name = "dbpath";
			this.dbpath.ReadOnly = true;
			this.dbpath.Size = new System.Drawing.Size(252, 21);
			this.dbpath.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Database Path:";
			// 
			// ChangeDatabaseBtn
			// 
			this.ChangeDatabaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ChangeDatabaseBtn.FlatAppearance.BorderSize = 0;
			this.ChangeDatabaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangeDatabaseBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangeDatabaseBtn.ForeColor = System.Drawing.Color.White;
			this.ChangeDatabaseBtn.Location = new System.Drawing.Point(12, 86);
			this.ChangeDatabaseBtn.Name = "ChangeDatabaseBtn";
			this.ChangeDatabaseBtn.Size = new System.Drawing.Size(120, 43);
			this.ChangeDatabaseBtn.TabIndex = 1;
			this.ChangeDatabaseBtn.Text = "Change Database";
			this.ChangeDatabaseBtn.UseVisualStyleBackColor = false;
			this.ChangeDatabaseBtn.Click += new System.EventHandler(this.ChangeDatabase_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 135);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(252, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Clear CheckOutItems";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// CreateDatabaseBtn
			// 
			this.CreateDatabaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CreateDatabaseBtn.FlatAppearance.BorderSize = 0;
			this.CreateDatabaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateDatabaseBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateDatabaseBtn.ForeColor = System.Drawing.Color.White;
			this.CreateDatabaseBtn.Location = new System.Drawing.Point(144, 86);
			this.CreateDatabaseBtn.Name = "CreateDatabaseBtn";
			this.CreateDatabaseBtn.Size = new System.Drawing.Size(120, 43);
			this.CreateDatabaseBtn.TabIndex = 2;
			this.CreateDatabaseBtn.Text = "Create New Database";
			this.CreateDatabaseBtn.UseVisualStyleBackColor = false;
			this.CreateDatabaseBtn.Click += new System.EventHandler(this.NewDatabase_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 173);
			this.Controls.Add(this.CreateDatabaseBtn);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.ChangeDatabaseBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dbpath);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Settings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox dbpath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ChangeDatabaseBtn;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button CreateDatabaseBtn;
	}
}