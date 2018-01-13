namespace SRIMS
{
	partial class CheckinDialog
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
			this._NumericUpDownQt = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this._BtnCheckin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._NumericUpDownQt)).BeginInit();
			this.SuspendLayout();
			// 
			// _NumericUpDownQt
			// 
			this._NumericUpDownQt.Location = new System.Drawing.Point(12, 25);
			this._NumericUpDownQt.Name = "_NumericUpDownQt";
			this._NumericUpDownQt.Size = new System.Drawing.Size(120, 20);
			this._NumericUpDownQt.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quantity to check in:";
			// 
			// _BtnCheckin
			// 
			this._BtnCheckin.Location = new System.Drawing.Point(12, 51);
			this._BtnCheckin.Name = "_BtnCheckin";
			this._BtnCheckin.Size = new System.Drawing.Size(120, 23);
			this._BtnCheckin.TabIndex = 2;
			this._BtnCheckin.Text = "Check In";
			this._BtnCheckin.UseVisualStyleBackColor = true;
			this._BtnCheckin.Click += new System.EventHandler(this._BtnCheckin_Click);
			// 
			// CheckinDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(145, 83);
			this.Controls.Add(this._BtnCheckin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._NumericUpDownQt);
			this.Name = "CheckinDialog";
			this.Text = "CheckinDialog";
			((System.ComponentModel.ISupportInitialize)(this._NumericUpDownQt)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown _NumericUpDownQt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _BtnCheckin;
	}
}